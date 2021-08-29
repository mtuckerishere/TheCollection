using System.Collections.Generic;
using System.Threading.Tasks;
using TheCollection.Models;
using TheCollection.Persistance.Context;
using TheCollection.Repository.Interfaces;

namespace TheCollection.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly TheCollectionDbContext _dbContext;
        public LocationRepository(TheCollectionDbContext dbContext){
            _dbContext = dbContext;
        }

        public Task CreateLocation(Locations location)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteLocation(Locations location)
        {
            throw new System.NotImplementedException();
        }

        public Task<Locations> GetLocation(int locationId)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<Locations>> GetLocations()
        {
            throw new System.NotImplementedException();
        }

        public bool LocationExists(int locationId)
        {
            throw new System.NotImplementedException();
        }

        public bool LocationExists(string locationName)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateLocation(Locations location)
        {
            throw new System.NotImplementedException();
        }
    }
}