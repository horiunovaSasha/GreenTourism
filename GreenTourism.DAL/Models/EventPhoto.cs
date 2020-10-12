namespace GreenTourism.DAL.Models
{
    public class EventPhoto
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public Photo Photo { get; set; }
    }
}
