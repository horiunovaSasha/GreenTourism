using GreenTourism.DAL.Data;
using GreenTourism.DAL.Models;
using GreenTourism.Domain.Repositories;

namespace GreenTourism.DAL.Repositories
{
    public class AmenityGroupRepository : Repository<AmenityGroup>, IAmenityGroupRepository
    {
        public AmenityGroupRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
