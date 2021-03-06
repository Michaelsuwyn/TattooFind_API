﻿using System;
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
            //IList<Idea> Ideas = _context.Ideas.Include(i => i.User).ToList();
            //return Ideas;
            return _context.Ideas.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Idea Get(int id)
        {
            return _context.Ideas.SingleOrDefault<Idea>(i => i.IdeaId == id);
        }

      
        [HttpPost]
        public void Post([FromBody]Idea Idea)
        {
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

            Idea deleter = _context.Ideas.SingleOrDefault<Idea>(i => i.IdeaId == id);
            _context.Ideas.Remove(deleter);
            _context.SaveChanges();
        }
    }
}
