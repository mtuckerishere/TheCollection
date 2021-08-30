using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheCollection.Models;
using TheCollection.Services;

namespace TheCollection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly LocationService _locationService;
        public LocationController(LocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public Task<ICollection<Locations>> GetLocations()
        {
            var locations = _locationService.GetAllLocations();
            return locations;
        }
    }
}