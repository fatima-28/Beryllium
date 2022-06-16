using Beryllium.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.DAL
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }


    }
}
