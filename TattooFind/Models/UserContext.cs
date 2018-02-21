using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TattooFind.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Artist> Artists { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Ideas)
                .WithOne(i => i.User);

            modelBuilder.Entity<Idea>()
               .HasMany(i => i.Comments)
               .WithOne(c => c.Idea);

            modelBuilder.Entity<Artist>()
               .HasMany(a => a.Comments)
               .WithOne(c => c.Artist);

        }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Idea>()
        //        .HasMany(i => i.Comments)
        //        .WithOne(c => c.Idea);
        //}

    }
}

   

