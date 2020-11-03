using GreenTourism.Domain.Entities;

namespace GreenTourism.DAL.Models
{
    public class PlaceComment : IEntity
    {
        public long Id { get; set; }
        public Place Place { get; set; }
        public Comment Comment { get; set; }
    }
}
