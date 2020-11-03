using GreenTourism.DAL.Data;
using GreenTourism.DAL.Models;
using GreenTourism.Domain.Repositories;

namespace GreenTourism.DAL.Repositories
{
    public class EventUserRepository : Repository<EventUser>, IEventUserRepository
    {
        public EventUserRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
