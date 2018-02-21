using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TattooFind.Models
{
    public class User

    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }


        public ICollection<Idea> Ideas { get; set; }

    }
}
