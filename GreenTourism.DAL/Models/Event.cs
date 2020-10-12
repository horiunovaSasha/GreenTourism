using System;

namespace GreenTourism.DAL.Models
{
    public class Event
    {
        public int Id { get; set; }
        public Place Place { get; set; }
        public ApplicationUser AuthorId { get; set; }
        public DateTime StatDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
