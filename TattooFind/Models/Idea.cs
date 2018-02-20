using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TattooFind.Models
{
    public class Idea
    {
        public int IdeaId { get; set; }
        public string ArtIdea { get; set; }
        public string Image { get; set; }
        public User User { get; set; }
       // public int UserId { get; set; }
    }
}
