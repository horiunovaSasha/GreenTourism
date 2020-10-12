using System;

namespace GreenTourism.DAL.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ApplicationUser User { get; set; }
        public int ReplyOnId { get; set; }
        public DateTime  CreatedDate { get; set; }
    }
}
