namespace GreenTourism.DAL.Models
{
    public class PlacePhoto
    {
        public int Id { get; set; }
        public Place Place { get; set; }
        public Photo Photo { get; set; }
    }
}
