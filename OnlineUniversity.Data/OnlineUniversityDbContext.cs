using Microsoft.EntityFrameworkCore;
using OnlineUniversity.Domain;

namespace OnlineUniversity.Data
{
    class OnlineUniversityDbContext : DbContext
    {
        public DbSet<Lecturer> Lecturers { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=onlineUniversity;Trusted_Connection=True;");
        }
    }
}
