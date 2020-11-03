using GreenTourism.Domain.Entities;

namespace GreenTourism.DAL.Models
{
    public class EventPhoto : IEntity
    {
        public long Id { get; set; }
        public Event Event { get; set; }
        public Photo Photo { get; set; }
    }
}
