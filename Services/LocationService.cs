using System.Collections.Generic;
using System.Threading.Tasks;
using TheCollection.Models;
using TheCollection.Repository.Interfaces;

namespace TheCollection.Services
{
    public class LocationService
    {
        private readonly ILocationRepository _locationRepository;
        public LocationService(ILocationRepository locationRepository){
            _locationRepository = locationRepository;
        }

        public async Task<ICollection<Locations>> GetAllLocations(){
            return await _locationRepository.GetLocations();
        }

        public async Task<Locations> GetLocations(int locationId){
            return await _locationRepository.GetLocation(locationId);
        }

        public void DeleteLocation(Locations location){
            _locationRepository.DeleteLocation(location);
        }

        public void UpdateLocation(Locations location){
            _locationRepository.UpdateLocation(location);
        }

    }
}