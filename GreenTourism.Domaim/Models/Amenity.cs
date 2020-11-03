using GreenTourism.Domain.Entities;

namespace GreenTourism.DAL.Models
{
    public class Amenity : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public AmenityGroup AmenityGroup { get; set; }
    }
}
