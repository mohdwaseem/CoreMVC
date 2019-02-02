using System;
using System.Collections.Generic;
using System.Text;
using CoreMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoreMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<LogModel> LogModels { get; set; }
        public DbSet<Contract> Contracts { get; set; }

    }
}
