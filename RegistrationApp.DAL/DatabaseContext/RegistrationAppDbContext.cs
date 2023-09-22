using Microsoft.EntityFrameworkCore;
using RegistrationApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.DAL.DatabaseContext
{
    public class RegistrationAppDbContext : DbContext
    {
        public RegistrationAppDbContext(DbContextOptions<RegistrationAppDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Personality> Personality { get; set; }
        public DbSet<PersonPersonality> PersonPersonality { get; set; }

    }
}
