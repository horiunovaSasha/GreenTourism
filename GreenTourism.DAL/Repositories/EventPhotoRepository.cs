using GreenTourism.DAL.Data;
using GreenTourism.DAL.Models;
using GreenTourism.Domain.Repositories;

namespace GreenTourism.DAL.Repositories
{
    public class EventPhotoRepository : Repository<EventPhoto>, IEventPhotoRepository
    {
        public EventPhotoRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
