using GreenTourism.Domain.Entities;

namespace GreenTourism.DAL.Models
{
    public class AmenityGroup : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
