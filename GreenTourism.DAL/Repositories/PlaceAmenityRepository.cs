using GreenTourism.DAL.Data;
using GreenTourism.DAL.Models;
using GreenTourism.Domain.Repositories;

namespace GreenTourism.DAL.Repositories
{
    public class PlaceAmenityRepository : Repository<PlaceAmenity>, IPlaceAmenityRepository
    {
        public PlaceAmenityRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
