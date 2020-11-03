using GreenTourism.DAL.Data;
using GreenTourism.DAL.Models;
using GreenTourism.Domain.Repositories;

namespace GreenTourism.DAL.Repositories
{
    public class PlacePhotoRepository : Repository<PlacePhoto>, IPlacePhotoRepository
    {
        public PlacePhotoRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
