using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateGame.Models
{
    public class DbContent : DbContext
    {
        public DbContent( DbContextOptions<DbContent> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<Game> games { set; get; }
        

    }
}
