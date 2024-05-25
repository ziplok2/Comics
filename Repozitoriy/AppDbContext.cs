using System;
using Comics.Model;
using Comics.Model.AuthApp;
using Microsoft.EntityFrameworkCore;

namespace Comics.Repozitoriy
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Comics.Model.Comics> Comicss { get; set; }
        public DbSet<AuthUser> AuthUsers { get; set; }
        public DbSet<SubjectGrade> SubjectGrades { get; set; }
        public DbSet<Subject> subjects { get; set; }
        
        
    }
}
