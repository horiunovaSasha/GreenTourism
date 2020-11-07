using GreenTourism.DAL.Models;
using System.Collections.Generic;

namespace GreenTourism.Domain.Repositories
{
    public interface IPlaceRepository : IRepository<Place> 
    {
        List<Place> GetPlacesWithImages();
    }
}
