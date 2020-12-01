using GreenTourism.DAL.Models;
using GreenTourism.Models;
using System.Linq;

namespace GreenTourism.Extensions
{
    public static class ModelMappings
    {
        public static PlaceViewModel ToPlaceViewModel(this Place place)
        {
            return new PlaceViewModel()
            {
                Id = place.Id,
                Name = place.Name,
                Description = place.Description,
                MainPhotoPath = place.PlacePhotos.FirstOrDefault()?.Photo?.Path,
                Rating = place.Rating,
                Region = place.Region,
                PlacePhotos = place.PlacePhotos,
                PlaceComments = place.PlaceComments,
                LocationCoords = place.LocationCoords,
            };
        }
    }
}
