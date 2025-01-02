using Athletics.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography.Xml;
using System.Text.RegularExpressions;

namespace Athletics
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Result> Results { get; set; }

    }
}
