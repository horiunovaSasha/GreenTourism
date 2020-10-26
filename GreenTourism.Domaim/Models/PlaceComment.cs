namespace GreenTourism.DAL.Models
{
    public class PlaceComment
    {
        public int Id { get; set; }
        public Place Place { get; set; }
        public Comment Comment { get; set; }
    }
}
