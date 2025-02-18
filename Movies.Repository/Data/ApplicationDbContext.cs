using Microsoft.EntityFrameworkCore;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Repository.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Certificates> Certificates { get; set; }
        public DbSet<Countrys> Countries { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Studios> Studios { get; set; }
    }
}
