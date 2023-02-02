using layered_Architecture.Core;
using layered_Architecture.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.DataAccess.Concrete.Context
{
    public class Context:DbContext
    {
        private readonly IOptions<AppSetting> _config;

        public DbSet<About> abouts { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Writer> writers { get; set; }
        public DbSet<writersCountry_City> writerscountry_city { get; set; }

        public Context(DbContextOptions<Context> options, IOptions<AppSetting> config) : base(options)
        {
            _config = config;
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
   
}
