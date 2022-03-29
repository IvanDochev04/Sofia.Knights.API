using System;

namespace SofiaKnights_API.Data.Models
{
    public class News
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Content { get; set; }

        public string PictureUrl { get; set; }

        public DateTime Date { get; set; }
    }
}
