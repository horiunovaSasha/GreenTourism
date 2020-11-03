using GreenTourism.Domain.Entities;

namespace GreenTourism.DAL.Models
{
    public class EventComment : IEntity
    {
        public long Id { get; set; }
        public Event Event { get; set; }
        public Comment Comment { get; set; }
    }
}
