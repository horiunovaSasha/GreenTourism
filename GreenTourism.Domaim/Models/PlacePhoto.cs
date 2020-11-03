using GreenTourism.Domain.Entities;

namespace GreenTourism.DAL.Models
{
    public class PlacePhoto : IEntity
    {
        public long Id { get; set; }
        public Place Place { get; set; }
        public Photo Photo { get; set; }
    }
}
