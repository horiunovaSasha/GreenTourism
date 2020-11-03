using GreenTourism.DAL.Data;
using GreenTourism.DAL.Models;
using GreenTourism.Domain.Repositories;

namespace GreenTourism.DAL.Repositories
{
    public class EventCommentRepository : Repository<EventComment>, IEventCommentRepository
    {
        public EventCommentRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
