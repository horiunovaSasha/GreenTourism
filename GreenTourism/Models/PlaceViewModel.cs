using GreenTourism.DAL.Models;
using System.Collections.Generic;

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
        public List<PlaceComment> PlaceComments { get; set; }
        public List<PlacePhoto> PlacePhotos { get; set; }
        public string LocationCoords { get; set; }
    }
}
