using GreenTourism.DAL.Data;
using GreenTourism.DAL.Models;
using GreenTourism.Domain.Repositories;

namespace GreenTourism.DAL.Repositories
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
