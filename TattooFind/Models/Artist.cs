using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TattooFind.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pricing { get; set; }


        public ICollection<Comment> Comments { get; set; }
    }
}
