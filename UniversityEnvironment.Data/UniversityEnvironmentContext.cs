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
        public DbSet<TestMark> TestMarks { get; set; }
        public DbSet<TestQuestion> TestQuestions { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
/*        public DbSet<CourseAdmin> CoursesAdmins { get; set; }
        public DbSet<CourseTeacher> CoursesTeachers { get; set; }
        public DbSet<CourseStudent> CoursesStudents { get; set; }*/

        public UniversityEnvironmentContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 3, 0));
            optionsBuilder.UseMySql("server=localhost;user=root;password=1234;database=UniversalEnvironment", serverVersion);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseAdmin>()
            .ToTable("coursesadmins")
            .HasKey(cs => new { cs.AdminId, cs.CourseId }); // Define composite primary key

            modelBuilder.Entity<CourseAdmin>()
            .ToTable("coursesadminss")
            .HasOne(cs => cs.Admin)
            .WithMany(s => s.CoursesAdmins) // Assuming Student has a navigation property CourseStudents
            .HasForeignKey(cs => cs.AdminId)
            .OnDelete(DeleteBehavior.Cascade); // Specify the delete behavior if a student is deleted

            modelBuilder.Entity<CourseAdmin>()
            .ToTable("coursesadmins")
            .HasOne(cs => cs.Course)
            .WithMany(c => c.CoursesAdmins) // Assuming Course has a navigation property CourseStudents
            .HasForeignKey(cs => cs.CourseId)
            .OnDelete(DeleteBehavior.Cascade); // Specify the delete behavior if a course is deleted

            modelBuilder.Entity<CourseTeacher>()
            .ToTable("coursesteachers")
            .HasKey(cs => new { cs.TeacherId, cs.CourseId }); // Define composite primary key

            modelBuilder.Entity<CourseTeacher>()
            .ToTable("coursesteachers")
            .HasOne(cs => cs.Teacher)
            .WithMany(s => s.CoursesTeachers) // Assuming Student has a navigation property CourseStudents
            .HasForeignKey(cs => cs.TeacherId)
            .OnDelete(DeleteBehavior.Cascade); // Specify the delete behavior if a student is deleted

            modelBuilder.Entity<CourseTeacher>()
            .ToTable("coursesteachers")
            .HasOne(cs => cs.Course)
            .WithMany(c => c.CoursesTeachers) // Assuming Course has a navigation property CourseStudents
            .HasForeignKey(cs => cs.CourseId)
            .OnDelete(DeleteBehavior.Cascade); // Specify the delete behavior if a course is deleted

            modelBuilder.Entity<CourseStudent>()
            .ToTable("coursesstudents")
            .HasKey(cs => new { cs.StudentId, cs.CourseId }); // Define composite primary key

            modelBuilder.Entity<CourseStudent>()
            .ToTable("coursesstudents")
            .HasOne(cs => cs.Student)
            .WithMany(s => s.CoursesStudents) // Assuming Student has a navigation property CourseStudents
            .HasForeignKey(cs => cs.StudentId)
            .OnDelete(DeleteBehavior.Cascade); // Specify the delete behavior if a student is deleted

            modelBuilder.Entity<CourseStudent>()
            .ToTable("coursesstudents")
            .HasOne(cs => cs.Course)
            .WithMany(c => c.CoursesStudents) // Assuming Course has a navigation property CourseStudents
            .HasForeignKey(cs => cs.CourseId)
            .OnDelete(DeleteBehavior.Cascade); // Specify the delete behavior if a course is deleted


            modelBuilder.Entity<TestStudent>()
            .ToTable("testsstudents")
            .HasKey(cs => new { cs.StudentId, cs.TestId }); // Define composite primary key

            modelBuilder.Entity<TestStudent>()
            .ToTable("testsstudents")
            .HasOne(cs => cs.Student)
            .WithMany(s => s.TestsStudents) // Assuming Student has a navigation property CourseStudents
            .HasForeignKey(cs => cs.StudentId)
            .OnDelete(DeleteBehavior.Cascade); // Specify the delete behavior if a student is deleted

            modelBuilder.Entity<TestStudent>()
            .ToTable("testsstudents")
            .HasOne(cs => cs.Test)
            .WithMany(c => c.TestsStudents) // Assuming Course has a navigation property CourseStudents
            .HasForeignKey(cs => cs.TestId)
            .OnDelete(DeleteBehavior.Cascade); // Specify the delete behavior if a course is deleted


            modelBuilder.Entity<QuestionAnswerStudent>()
            .ToTable("questionanswersstudents")
            .HasKey(cs => new { cs.StudentId, cs.QuestionAnswerId }); // Define composite primary key

            modelBuilder.Entity<QuestionAnswerStudent>()
            .ToTable("questionanswersstudents")
            .HasOne(cs => cs.Student)
            .WithMany(s => s.QuestionAnswersStudent) // Assuming Student has a navigation property CourseStudents
            .HasForeignKey(cs => cs.StudentId)
            .OnDelete(DeleteBehavior.Cascade); // Specify the delete behavior if a student is deleted

            modelBuilder.Entity<QuestionAnswerStudent>()
            .ToTable("questionanswersstudents")
            .HasOne(cs => cs.QuestionAnswer)
            .WithMany(c => c.QuestionAnswersStudents) // Assuming Course has a navigation property CourseStudents
            .HasForeignKey(cs => cs.QuestionAnswerId)
            .OnDelete(DeleteBehavior.Cascade); // Specify the delete behavior if a course is deleted
        }
    }
}
