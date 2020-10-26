namespace GreenTourism.DAL.Models
{
    public class Amenity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AmenityGroup AmenityGroup { get; set; }
    }
}
