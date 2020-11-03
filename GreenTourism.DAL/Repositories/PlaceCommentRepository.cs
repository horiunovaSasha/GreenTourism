using GreenTourism.DAL.Data;
using GreenTourism.DAL.Models;
using GreenTourism.Domain.Repositories;

namespace GreenTourism.DAL.Repositories
{
    public class PlaceCommentRepository : Repository<PlaceComment>, IPlaceCommentRepository
    {
        public PlaceCommentRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
