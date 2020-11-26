using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebApp.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
