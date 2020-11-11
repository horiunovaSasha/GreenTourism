using GreenTourism.DAL.Data;
using GreenTourism.DAL.Models;
using GreenTourism.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenTourism.DAL.Repositories
{
    public class PlaceRepository : Repository<Place>, IPlaceRepository
    {
        public PlaceRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<List<Place>> GetPlacesWithImages() 
        {
            return  await dbContext.Set<Place>()
                .Include(i=>i.PlacePhotos)
                .ThenInclude(x=>x.Photo)
                .Include(r=>r.Region)
                .ToListAsync();
        }

        public async Task<Place> GetDetailsPage(long id)
        {
            return await dbContext.Set<Place>()
                .Include(i => i.PlacePhotos)
                .ThenInclude(x => x.Photo)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
