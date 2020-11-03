using GreenTourism.DAL.Data;
using GreenTourism.DAL.Models;
using GreenTourism.Domain.Repositories;

namespace GreenTourism.DAL.Repositories
{
    public class AmenityRepository : Repository<Amenity>, IAmenityRepository
    {
        public AmenityRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
