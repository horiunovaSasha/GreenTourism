namespace GreenTourism.DAL.Models
{
    public class EventUser
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public ApplicationUser ApplicationUser {get; set;}
    }
}
