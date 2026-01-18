using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthIsWealth.Data;
using HealthIsWealth.Domain;
using HealthIsWealth.Configurations.Entities;
using HealthIsWealth.Domain.Dto;

namespace HealthIsWealth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenueController : ControllerBase
    {
        private readonly HealthIsWealthContext _context;

        public VenueController(HealthIsWealthContext context)
        {
            _context = context;
        }

        // GET: api/Venue
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venue>>> GetVenue()
        {
            var response = _context.Venue.Select(v => new VenueDto
            {
                VenueId = v.VenueId,
                Address = v.Address,
                Name = v.Name,
                PostalCode = v.PostalCode,
                UnitNumber = v.UnitNumber,
                Facilities = (ICollection<FacilityDto>)_context.Facility.Where(f => f.VenueId == v.VenueId).Select(f => new FacilityDto
                {
                    FacilityId = f.FacilityId,
                    Location = f.Location,
                    Name = f.Name,
                    Price = f.Price,
                    Sports = (ICollection<SportDto>)_context.FacilitySport.Where(fs => fs.FacilityId == f.FacilityId)
                        .Include(fs => fs.Sport).Select(fs => new SportDto
                        {
                            Description = fs.Sport.Description,
                            Name = fs.Sport.Name,
                            SportId = fs.Sport.SportId
                        }),
                    Timeslots = (ICollection<TimeslotDto>)_context.Timeslot.Where(t => t.FacilityId == f.FacilityId).Select(
                        t => new TimeslotDto
                        {
                            EndDT = t.EndDT,
                            StartDT = t.StartDT,
                            TimeslotId = t.TimeslotId
                        })
                })
            });
            
            return Ok(response);
        }

        // GET: api/Venue/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Venue>> GetVenue(int id)
        {
            if (!VenueExists(id))
            {
                return NotFound();
            }
            var v = await _context.Venue.FirstAsync(v => v.VenueId == id);
            var response = new VenueDto
            {
                VenueId = v.VenueId,
                Address = v.Address,
                Name = v.Name,
                PostalCode = v.PostalCode,
                UnitNumber = v.UnitNumber,
                Facilities = await _context.Facility.Where(f => f.VenueId == v.VenueId).Select(f => new FacilityDto
                {
                    FacilityId = f.FacilityId,
                    Location = f.Location,
                    Name = f.Name,
                    Price = f.Price,
                    Sports = (ICollection<SportDto>)_context.FacilitySport.Where(fs => fs.FacilityId == f.FacilityId)
                        .Include(fs => fs.Sport).Select(fs => new SportDto
                        {
                            Description = fs.Sport.Description,
                            Name = fs.Sport.Name,
                            SportId = fs.Sport.SportId
                        }),
                    Timeslots = (ICollection<TimeslotDto>)_context.Timeslot.Where(t => t.FacilityId == f.FacilityId).Select(
                        t => new TimeslotDto
                        {
                            EndDT = t.EndDT,
                            StartDT = t.StartDT,
                            TimeslotId = t.TimeslotId
                        })
                }).ToListAsync()
            };
            return Ok(response);
        }

        private bool VenueExists(int id)
        {
            return _context.Venue.Any(e => e.VenueId == id);
        }
    }
}
