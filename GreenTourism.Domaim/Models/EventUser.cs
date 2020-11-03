using GreenTourism.Domain.Entities;

namespace GreenTourism.DAL.Models
{
    public class EventUser : IEntity
    {
        public long Id { get; set; }
        public Event Event { get; set; }
        public ApplicationUser ApplicationUser {get; set;}
    }
}
