using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using HealthIsWealth.Data;
using HealthIsWealth.Domain;
using System.IO;


namespace HealthIsWealth.Components.Account.Pages.ProfilePages {
    public partial class UserProfile
    {
        // Inject
        [Inject] public AuthenticationStateProvider AuthenticationStateProvider { get; set; } = default!;
        [Inject] public UserManager<HealthIsWealthUser> UserManager { get; set; } = default!;
        [Inject] public IDbContextFactory<HealthIsWealth.Data.HealthIsWealthContext> DbFactory { get; set; } = default!;
        [Inject] public IWebHostEnvironment Environment { get; set; } = default!;
        [Inject] NavigationManager NavigationManager { get; set; } = default!;

        //Database
        private HealthIsWealthContext dbContext = default!;
        private HealthIsWealthUser? currentUser;

        // Variables for display
        private string? image;
        private List<Booking> pastBookings = new();

        // Variables for Editing
        private bool isEditingName = false;
        private bool isEditingPhone = false;
        private bool isEditingPhoto = false;
        private bool isEditingEmail = false;

        // New items
        private string? newFirstName;
        private string? newLastName;
        private string? newPhoneNumber;
        private string? newEmail;

        // Variables for Photo Upload
        private IBrowserFile? selectedFile;
        private string? previewImage;
        private long maxFileSize = 1024 * 1024 * 10;

        //error
        private string? nameErrorMessage;
        private string? phoneErrorMessage;
        private string? photoErrorMessage;
        private string? emailErrorMessage;

        protected override async Task OnInitializedAsync()
        {
            bool isAuthenticated = await authenticateUser();
            if (isAuthenticated)
            {
                await loadBookings();
            }
        }


        private async Task<bool> authenticateUser()
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            if (user.Identity != null && user.Identity.IsAuthenticated)
            {
                currentUser = await UserManager.GetUserAsync(user);
                if (currentUser != null)
                {
                    image = currentUser.ProfilePictureUrl;
                    return true;
                }
            }
            return false;
        }


        private async Task loadBookings()
        {

            if (currentUser == null) return;

            dbContext = DbFactory.CreateDbContext();

            var allBookings = await dbContext.Booking
                .Include(b => b.Timeslot)
                .ThenInclude(t => t.Facility)
                .ThenInclude(f => f.Venue)
                .Where(b => b.UserId == currentUser.Id)
                .OrderByDescending(b => b.Timeslot.StartDT)
                .ToListAsync();

            pastBookings = allBookings.Where(b => b.Timeslot.StartDT <= DateTime.Now).ToList();
        }
        //photo editing section
        private void EditPhoto()
        {
            isEditingPhoto = true;
            selectedFile = null;
            previewImage = null;
            photoErrorMessage = null;
        }

        private void CancelEditPhoto()
        {
            isEditingPhoto = false;
            selectedFile = null;
            previewImage = null;
            photoErrorMessage = null;
        }

        private void CheckValidPhoto(InputFileChangeEventArgs e)
        {
            photoErrorMessage = null;
            selectedFile = e.File;
            if (selectedFile.Size > maxFileSize)
            {
                photoErrorMessage = "File size exceeds limit.";
                selectedFile = null;
                return;
            }

            if (selectedFile.ContentType != "image/jpeg" && selectedFile.ContentType != "image/png")
            {
                photoErrorMessage = "Only JPG and PNG files are allowed.";
                selectedFile = null;
                return;
            }
        }

        private async Task GeneratePreview(InputFileChangeEventArgs e)
        {

            try
            {
                var buffer = new byte[selectedFile.Size];
                using var stream = selectedFile.OpenReadStream(maxFileSize);
                await stream.ReadAsync(buffer);
                var imageData = Convert.ToBase64String(buffer);
                previewImage = $"data:{selectedFile.ContentType};base64,{imageData}";
            }
            catch (Exception ex)
            {
                photoErrorMessage = "Error creating preview: " + ex.Message;
                selectedFile = null;
            }
        }

        private async Task HandleFileSelected(InputFileChangeEventArgs e)
        {
            CheckValidPhoto(e);
            if (selectedFile == null) return;
            await GeneratePreview(e);
        }

        private async Task SavePhoto()
        {
            if (selectedFile == null || currentUser == null) return;

            try
            {
                var folderPath = Path.Combine(Environment.WebRootPath, "uploads", "profiles");
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

                var extension = Path.GetExtension(selectedFile.Name);
                var fileName = $"{currentUser.Id}_{Guid.NewGuid()}{extension}";
                var filePath = Path.Combine(folderPath, fileName);

                using (var fs = new FileStream(filePath, FileMode.Create))
                {
                    using var stream = selectedFile.OpenReadStream(maxFileSize);
                    await stream.CopyToAsync(fs);
                }

                var oldUrl = currentUser.ProfilePictureUrl;
                var relativePath = $"/uploads/profiles/{fileName}";
                currentUser.ProfilePictureUrl = relativePath;

                var result = await UserManager.UpdateAsync(currentUser);

                if (result.Succeeded)
                {
                    image = relativePath;
                    isEditingPhoto = false;
                    selectedFile = null;
                    previewImage = null;
                    photoErrorMessage = null;
                    NavigationManager.NavigateTo(NavigationManager.Uri, forceLoad: true);
                }
                else
                {
                    File.Delete(filePath);
                    photoErrorMessage = "Failed to update profile.";
                }
            }
            catch (Exception ex)
            {
                photoErrorMessage = "Error saving file: " + ex.Message;
            }
        }

        // name editing section
        private void EditName()
        {
            isEditingName = true;
            nameErrorMessage = null;
            newFirstName = currentUser?.FirstName;
            newLastName = currentUser?.LastName;
        }

        private void CancelEditName()
        {
            isEditingName = false;
            nameErrorMessage = null;
            newFirstName = currentUser?.FirstName;
            newLastName = currentUser?.LastName;
        }

        private async Task SaveName()
        {
            nameErrorMessage = null;

            var existingUser = await dbContext.Users
            .Where(u => u.Id != currentUser.Id && u.FirstName == newFirstName && u.LastName == newLastName)
            .FirstOrDefaultAsync();

            if (existingUser != null)
            {
                nameErrorMessage = "This name is already taken. Please choose a different one.";
                return;
            }

            currentUser.FirstName = newFirstName;
            currentUser.LastName = newLastName;
            await UserManager.UpdateAsync(currentUser);

            isEditingName = false;
        }

        //contact number editing section

        private void EditPhone()
        {
            phoneErrorMessage = null;
            isEditingPhone = true;
            newPhoneNumber = currentUser?.PhoneNumber;
        }

        private void CancelEditPhone()
        {
            isEditingPhone = false;
            phoneErrorMessage = null;
            newPhoneNumber = currentUser?.PhoneNumber;
        }

        private bool HasPhoneErrors()
        {
            phoneErrorMessage = null;

            if (string.IsNullOrWhiteSpace(newPhoneNumber))
            {
                phoneErrorMessage = "Phone number is required.";
                return true; 
            }

            if (!newPhoneNumber.All(char.IsDigit))
            {
                phoneErrorMessage = "Phone number must contain only digits.";
                return true;
            }

            if (newPhoneNumber.Length != 8)
            {
                phoneErrorMessage = "Phone number must be exactly 8 digits.";
                return true;
            }

            return false;
        }

        private async Task SavePhone()
        {
            phoneErrorMessage = null;

            if (!string.IsNullOrWhiteSpace(newPhoneNumber))
            {

                if (HasPhoneErrors()) return;

                var existingUser = await dbContext.Users
                    .Where(u => u.Id != currentUser.Id && u.PhoneNumber == newPhoneNumber)
                    .FirstOrDefaultAsync();

                if (existingUser != null)
                {
                    phoneErrorMessage = "This phone number is already registered to another user.";
                    return;
                }
            }

            currentUser.PhoneNumber = newPhoneNumber;
            await UserManager.UpdateAsync(currentUser);

            isEditingPhone = false;
        }

        //Email editing section


        private void EditEmail()
        {
            emailErrorMessage = null;
            isEditingEmail = true;
            newEmail = currentUser?.Email;
        }

        private void CancelEditEmail()
        {
            emailErrorMessage = null;
            isEditingEmail = false;
            newEmail = currentUser?.Email;
        }

        private bool HasEmailErrors()
        {
            emailErrorMessage = null;

            if (string.IsNullOrWhiteSpace(newEmail))
            {
                emailErrorMessage = "Email is required.";
                return true;
            }

            if (!newEmail.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                emailErrorMessage = "Email address must end with @gmail.com";
                return true;
            }

            return false;
        }

        private async Task SaveEmail()
        {
            emailErrorMessage = null;

            if (!string.IsNullOrWhiteSpace(newEmail))
            {

                if (HasEmailErrors()) return;

                var existingUser = await dbContext.Users
                    .Where(u => u.Id != currentUser.Id && u.Email == newEmail)
                    .FirstOrDefaultAsync();

                if (existingUser != null)
                {
                    emailErrorMessage = "This email address is already registered to another user.";
                    return;
                }
            }

            currentUser.Email = newEmail;
            await UserManager.UpdateAsync(currentUser);

            isEditingEmail = false;
        }
    }
}