using System;

namespace GreenTourism.DAL.Models
{
    public class Event
    {
        public int Id { get; set; }
        public Place Place { get; set; }
        public Guid AuthorId { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
