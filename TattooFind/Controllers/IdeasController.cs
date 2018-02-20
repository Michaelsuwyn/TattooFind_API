using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TattooFind.Models;
using Microsoft.EntityFrameworkCore;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TattooFind.Controllers
{
    [Route("api/[controller]")]
    public class IdeasController : Controller
    {

        private UserContext _context;

        public IdeasController(UserContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Idea> Get()
        {
            return _context.Ideas.Include( x => x.User).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]Idea Idea)
        //{
        //    var newUser = _context.Users.FirstOrDefault(u => u.UserId == Idea.User.UserId);
        //    if (newUser != null)
        //    {
        //        Idea.User = newUser;

        //    }
        //    _context.Add(Idea);
        //    _context.SaveChanges();
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Idea Idea)
        {
            var newUser = _context.Users.FirstOrDefault(u => u.UserId == Idea.User.UserId);
            if (newUser != null)
            {
                Idea.User = newUser;

            }
            _context.Add(Idea);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
