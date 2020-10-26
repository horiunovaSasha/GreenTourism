using GreenTourism.Domain.Entities;

namespace GreenTourism.DAL.Models
{
    public class Region :IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
