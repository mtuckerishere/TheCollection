using System.Collections.Generic;
using System.Threading.Tasks;
using TheCollection.Models;

namespace TheCollection.Repository.Interfaces
{
    public interface ILocationRepository
    {
        Task<ICollection<Locations>> GetLocations();
        Task CreateLocation(Locations location);
        Task<Locations> GetLocation(int locationId);
        bool LocationExists(int locationId);
        bool LocationExists(string locationName);
        void UpdateLocation(Locations location);
        void DeleteLocation(Locations location); 
        
    }
}