using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model;

namespace UniversityEnvironment.Data
{
    public class UniversityEnvironmentContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestMarks> TestMarks { get; set; }
        public DbSet<TestQuestion> TestQuestion { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswer { get; set; }

        public UniversityEnvironmentContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 3, 0));
            optionsBuilder.UseMySql("server=localhost;user=root;password=1111;database=UniversalEnvironment", serverVersion);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            14tr0ll23
            /*modelBuilder.Entity<Course>()
                .HasMany(a => a.Admins)
                .WithMany(c => c.Courses)
                .UsingEntity(t => t.ToTable("Courses"));
            modelBuilder.Entity<Course>()
                .HasMany(a => a.Teachers)
                .WithMany(c => c.Courses)
                .UsingEntity(t => t.ToTable("Courses"));
            modelBuilder.Entity<Course>()
                .HasMany(a => a.Students)
                .WithMany(c => c.Courses)
                .UsingEntity(t => t.ToTable("Courses"));

            modelBuilder.Entity<Course>()
                .HasMany(t => t.Tests)
                .WithOne(c => c.Course)
                .HasForeignKey(c => c.Course);

            modelBuilder.Entity<Test>()
                .HasMany(q => q.Questions)
                .WithOne(t => t.Test)
                .HasForeignKey(t => t.Test);

            modelBuilder.Entity<TestQuestion>()
                .HasMany(a => a.Answers)
                .WithOne(q => q.Question)
                .HasForeignKey(tq => tq.Question);*/
        }
    }
}
