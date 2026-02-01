using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TitanHelpApplication.Models;

namespace TitanHelpApplication.Data
{
    public class TitanHelpApplicationContext : DbContext
    {
        public TitanHelpApplicationContext (DbContextOptions<TitanHelpApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<TitanHelpApplication.Models.Ticket> Ticket { get; set; } = default!;
    }
}
