using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TattooFind.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Answer { get; set; }
        public string Image { get; set; }

        public int IdeaId { get; set; }
        public Idea Idea { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}
