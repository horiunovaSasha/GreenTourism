using GreenTourism.DAL.Models;

namespace GreenTourism.Models
{
    public class PlaceViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Region Region { get; set; }
        public decimal Rating { get; set; }
        public string MainPhotoPath { get; set; }
    }
}
