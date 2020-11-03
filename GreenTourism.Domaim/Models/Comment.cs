using GreenTourism.Domain.Entities;
using System;

namespace GreenTourism.DAL.Models
{
    public class Comment : IEntity
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public ApplicationUser User { get; set; }
        public int ReplyOnId { get; set; }
        public DateTime  CreatedDate { get; set; }
    }
}
