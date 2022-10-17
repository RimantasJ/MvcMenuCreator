using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMenuCreator.Models;

namespace MvcMenuCreator.Data
{
    public class MvcMenuCreatorContext : DbContext
    {
        public MvcMenuCreatorContext (DbContextOptions<MvcMenuCreatorContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMenuCreator.Models.MenuItem> MenuItem { get; set; } = default!;
    }
}
