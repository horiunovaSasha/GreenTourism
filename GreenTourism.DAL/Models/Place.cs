﻿namespace GreenTourism.DAL.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LocationCoords { get; set; }
        public Region Region { get; set; }
        public decimal Rating { get; set; }
        public Season Season { get; set; }
    }
}
