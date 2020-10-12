namespace GreenTourism.DAL.Models
{
    public class PlaceAmenity
    {
        public int Id { get; set; }
        public Place Place { get; set; }
        public Amenity Amenity { get; set; }
    }
}
