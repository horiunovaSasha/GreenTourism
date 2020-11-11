using GreenTourism.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreenTourism.Domain.Repositories
{
    public interface IPlaceRepository : IRepository<Place> 
    {
        Task<List<Place>> GetPlacesList();
        Task<Place> GetDetailsPage(long id);
    }
}
