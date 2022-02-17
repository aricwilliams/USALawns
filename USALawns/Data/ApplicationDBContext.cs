using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using USALawns.Controllers;
using USALawns.Models;

namespace USALawns.Data
{
    public class ApplicationDBContext : IdentityDbContext 
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Jobs> Job { get; set; }
        public DbSet<Customers> Customers { get; set; }

        public DbSet<Estimates> Estimates { get; set; }
        internal IEnumerable<Jobs> Jobs { get; set; }
        internal IEnumerable<Estimates> Estimate { get; set; }
        internal IEnumerable<Customers> Customer { get; set; }

    }
}
//in this file I set up options for database