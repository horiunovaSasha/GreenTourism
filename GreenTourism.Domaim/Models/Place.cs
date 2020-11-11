using GreenTourism.Domain.Entities;
using System.Collections.Generic;

namespace GreenTourism.DAL.Models
{
    public class Place : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LocationCoords { get; set; }
        public Region Region { get; set; }
        public decimal Rating { get; set; }
        public Season Season { get; set; }
        public virtual List<PlacePhoto> PlacePhotos { get; set; }
    }
}
