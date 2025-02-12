using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GalaxyForum.Models;

namespace GalaxyForum.Data
{

    public class GalaxyForumContext : DbContext
    {
        public GalaxyForumContext(DbContextOptions<GalaxyForumContext> options)
            : base(options)
        {
        }

        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}