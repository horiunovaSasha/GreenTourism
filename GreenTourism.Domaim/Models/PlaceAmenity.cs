using GreenTourism.Domain.Entities;

namespace GreenTourism.DAL.Models
{
    public class PlaceAmenity : IEntity
    {
        public long Id { get; set; }
        public Place Place { get; set; }
        public Amenity Amenity { get; set; }
    }
}
