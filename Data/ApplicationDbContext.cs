using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using finalApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace finalApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Users> Users { get; set; }

    }
}
