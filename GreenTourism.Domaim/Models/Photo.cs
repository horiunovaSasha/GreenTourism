using GreenTourism.Domain.Entities;

namespace GreenTourism.DAL.Models
{
    public class Photo : IEntity
    {
        public long Id { get; set; }
        public string Path { get; set; }
    }
}
