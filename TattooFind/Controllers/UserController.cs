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
    public class UserController : Controller
    {
        private UserContext _context;

        public UserController(UserContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.Users.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return new Models.User();
        }

        // POST api/values
        [HttpPost]
        public User Post([FromBody]User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]User value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            User deleter = _context.Users.SingleOrDefault<User>(u => u.UserId == id);
            _context.Users.Remove(deleter);
            _context.SaveChanges();
        }
    }
}
