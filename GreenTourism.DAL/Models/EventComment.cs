namespace GreenTourism.DAL.Models
{
    public class EventComment
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public Comment Comment { get; set; }
    }
}
