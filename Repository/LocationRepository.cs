using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheCollection.Models;
using TheCollection.Persistance.Context;
using TheCollection.Repository.Interfaces;

namespace TheCollection.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly TheCollectionDbContext _dbContext;
        public LocationRepository(TheCollectionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateLocation(Locations location)
        {
            await _dbContext.Locations.AddAsync(location);
        }

        public void DeleteLocation(Locations location)
        {
            _dbContext.Locations.Remove(location);
        }

        public async Task<Locations> GetLocation(int locationId)
        {
            return await _dbContext.Locations.Where(x => x.Id == locationId).FirstOrDefaultAsync();
        }

        public async Task<ICollection<Locations>> GetLocations()
        {
            return await _dbContext.Locations.ToListAsync();
        }
        public void UpdateLocation(Locations location)
        {
            _dbContext.Locations.Update(location);
        }
        public async Task<bool> LocationExists(int locationId)
        {
            return await _dbContext.Locations.AnyAsync(x => x.Id == locationId);
        }
    }
}