using EF_CodeFirst.Models.Dbo;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Student> Student { get; set; }

        protected   override void OnModelCreating(ModelBuilder modeluilder)
        {
            modeluilder.Entity<Student>().HasData(
                    new Student
                    {
                        Id = 1,
                        StudentName = "Borka Borkić",
                        DateOfBirth = DateTime.UtcNow,
                        Height = 170,
                        Weight = 65
                    },
                    new Student
                    {
                        Id = 2,
                        StudentName = "Joža Kožić",
                        DateOfBirth = DateTime.UtcNow,
                        Height = 180,
                        Weight = 97
                    }
                );

            modeluilder.Entity<Grade>().HasData(
                new Grade { Id = 1, StudentId = 1, GradeName = "Odličan", Section = "Hravtski", Title = "5" },
                new Grade { Id = 2, StudentId = 1, GradeName = "Vrlo dobar", Section = "Likovni", Title = "4" },
                new Grade { Id = 3, StudentId = 1, GradeName = "Dobar", Section = "Matematika", Title = "3" },
                new Grade { Id = 4, StudentId = 2, GradeName = "Odličan", Section = "Matematika", Title = "5" },
                new Grade { Id = 5, StudentId = 2, GradeName = "Dovoljan", Section = "Glazbeni", Title = "2" },
                new Grade { Id = 6, StudentId = 2, GradeName = "Vrlo dobar", Section = "Hravtski", Title = "4" },
                new Grade { Id = 7, StudentId = 1, GradeName = "Dovoljan", Section = "Informatika", Title = "2" }
                );
        }
    }
}