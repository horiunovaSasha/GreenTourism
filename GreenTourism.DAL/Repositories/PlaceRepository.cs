using GreenTourism.DAL.Data;
using GreenTourism.DAL.Models;
using GreenTourism.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GreenTourism.DAL.Repositories
{
    public class PlaceRepository : Repository<Place>, IPlaceRepository
    {
        public PlaceRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public List<Place> GetPlacesWithImages() 
        {
            return dbContext.Set<Place>()
                .Include(i=>i.MainPhoto)
                .Include(r=>r.Region)
                .Include(m=> m.MainPhoto)
                .ToList();
        }
    }
}
