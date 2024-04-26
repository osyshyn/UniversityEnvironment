using UniversityEnvironment.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static UniversityEnvironment.View.Utility.Constants;
using static System.Net.Mime.MediaTypeNames;
using UniversityEnvironment.Data.Repository;
using static System.Runtime.InteropServices.JavaScript.JSType;
using UniversityEnvironment.Data.Repositories;
using UniversityEnvironment.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.Devices;

namespace UniversityEnvironment.View.Utility
{
    public static class ViewGridHelper
    {
        public static void CoursesTableAddRows(DataGridView table, IEnumerable<Course> courses)
        {
            ArgumentNullException.ThrowIfNull(courses);

            foreach (var course in courses)
            {
                table.Rows.Add(false, course.Name, course.FacultyName);
            }
        }
        public static void UpdateTableWithAvailableCourses(DataGridView table, List<Course> courses)
        {
            table.Rows.Clear();

            foreach (var course in courses)
            {
                table.Rows.Add(false, course.Name, course.FacultyName);
            }
        }
        public static void UpdateTableWithActualCourses(DataGridView table, User user)
        {
            if(user.Role == "Admin")
            {
                Admin? admin = RepositoryManager.GetRepo<Admin>().FindById(user.Id);
                ArgumentNullException.ThrowIfNull(admin);
                if (admin.Courses == null) { return; }
                CoursesTableAddRows(table, admin.Courses);
            }
            else if(user.Role == "Teacher")
            {
                Teacher? teacher = RepositoryManager.GetRepo<Teacher>().FindById(user.Id);
                ArgumentNullException.ThrowIfNull(teacher);
                if(teacher.Courses == null) { return; }
                CoursesTableAddRows(table, teacher.Courses);
            }
            else if(user.Role == "Student")
            {
                Student? student = RepositoryManager.GetRepo<Student>().FindById(user.Id);
                ArgumentNullException.ThrowIfNull(student);
                if (student.Courses == null) { return; }
                CoursesTableAddRows(table, student.Courses);
            }
            else { throw new Exception("Bad user role"); }
        }

        public static void UpdateTableWithActualCourses<T>(DataGridView table, T user) where T : User
        {
            T? _user = RepositoryManager.GetRepo<T>().FindById(user.Id);
            ArgumentNullException.ThrowIfNull(_user);
            if (_user.Courses == null) { return; }
            CoursesTableAddRows(table, _user.Courses);
        }


        public static void SignUserOnCourse(DataGridView table, User user)
        {
            var courses = RepositoryManager.GetRepo<Course>().GetAll().ToList();
            if (user.Role == "Admin")
            {
                var admin = RepositoryManager.GetRepo<Admin>().FindById(user.Id);
                ArgumentNullException.ThrowIfNull(admin);

                for (int i = 0; i < courses.Count; i++)
                {
                    //var value = table.Rows[i].Cells[0].Value;
                    //if (value != null && bool.TryParse(value.ToString(), out bool parsed) && parsed)
                    //{
                    //    selectedCourses.Add(courses[i]);
                    //}
                }
            }
            if (user.Role == "Teacher")
            {
                var teacher = RepositoryManager.GetRepo<Teacher>().FindById(user.Id);
                ArgumentNullException.ThrowIfNull(teacher);
                teacher.Courses ??= new List<Course>();
                for (int i = 0; i < courses.Count; i++)
                {
                    if ((bool)table.Rows[i].Cells[0].Value == true)
                    {
                        var course = courses[i];
                        
                        teacher.Courses.Add(course);
                    }
                }
                RepositoryManager.GetRepo<Teacher>().Update(teacher);
            }
            if (user.Role == "Student")
            {
                var studentCourses = new List<CourseStudent>();
                var student = RepositoryManager.GetRepo<Student>().FindById(user.Id);
                ArgumentNullException.ThrowIfNull(student);
                for (int i = 0; i < courses.Count; i++)
                {
                    var value = table.Rows[i].Cells[0].Value;
                    if (value != null && bool.TryParse(value.ToString(), out bool parsed) && parsed)
                    {
                        studentCourses.Add(new()
                        {
                            StudentsId = user.Id,
                            CoursesId = courses[i].Id
                        });
                    }
                }

                RepositoryManager.GetRepo<CourseStudent>().Create(studentCourses);
            }
            else { throw new Exception("Bad user role"); }
            MessageBox.Show("Successfull signed on courses!", "Environment", MessageBoxButtons.OK);
        }
        public static void UnsignUserFromCourse(DataGridView table, User user) 
        {
            List<Course> courses = RepositoryManager.GetRepo<Course>().GetAll().ToList();

            if (user.Role == "Admin")
            {
                var admin = RepositoryManager.GetRepo<Admin>().FindById(user.Id);
                ArgumentNullException.ThrowIfNull(admin);
                admin.Courses ??= new List<Course>();
                for (int i = 0; i < courses.Count; i++)
                {
                    if ((bool)table.Rows[i].Cells[0].Value == true)
                    {
                        var course = courses[i];
                        admin.Courses.Remove(course);
                    }
                }
                RepositoryManager.GetRepo<Admin>().Update(admin);
            }
            if (user.Role == "Teacher")
            {
                var teacher = RepositoryManager.GetRepo<Teacher>().FindById(user.Id);
                ArgumentNullException.ThrowIfNull(teacher);
                teacher.Courses ??= new List<Course>();
                for (int i = 0; i < courses.Count; i++)
                {
                    if ((bool)table.Rows[i].Cells[0].Value == true)
                    {
                        var course = courses[i];
                        teacher.Courses.Remove(course);
                    }
                }
                RepositoryManager.GetRepo<Teacher>().Update(teacher);
            }
            if (user.Role == "Student")
            {
                var student = RepositoryManager.GetRepo<Student>().FindById(user.Id);
                ArgumentNullException.ThrowIfNull(student);
                student.Courses ??= new List<Course>();
                for (int i = 0; i < courses.Count; i++)
                {
                    if ((bool)table.Rows[i].Cells[0].Value == true)
                    {
                        var course = courses[i];
                        student.Courses.Remove(course);
                    }
                }
                RepositoryManager.GetRepo<Student>().Update(student);

            }
            else { throw new Exception("Bad user role"); }
            MessageBox.Show("Successfully unsigned from courses!", "Environment", MessageBoxButtons.OK);
        }
        /* public static void UpdateTeacherTable(DataGridView table, List<Course> courses, Course course)
         {
             foreach (var user in course.Users)
             {
                 if (user.Role == "Teacher" && table != null)
                 {
                     DataGridViewRow newRow = new DataGridViewRow();
                     DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                     nameCell.Value = user.Username;
                     newRow.Cells.Add(nameCell);
                     table.Rows.Add(newRow);
                 }
             }
         }
         public static void UpdateContentOfTableJournal(DataGridView table, List<Course> courses, Course course)
         {
             foreach (var test in course.Tests)
             {
                 if (table.Columns[test.Name] == null)
                 {
                     DataGridViewTextBoxColumn testColumn = new DataGridViewTextBoxColumn();
                     testColumn.HeaderText = test.Name;
                     testColumn.Name = test.Name;
                     testColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                     table.Columns.Add(testColumn);
                 }
             }

             foreach (var test in course.Tests)
             {
                 foreach (var student in test.Students)
                 {
                     bool match = false;
                     if (table.Rows.Count != 0)
                     {
                         Console.WriteLine();
                         foreach (DataGridViewRow row in table.Rows)
                         {
                             if (row.Cells[0].Value.ToString() == student.Username)
                             {
                                 row.Cells[course.Tests.FindIndex(t => t.Id == test.Id) + 1].Value = student.Mark;
                                 match = true;
                                 break;
                             }
                         }
                     }
                     if (!match)
                     {
                         List<Course> lists = RepoImplementation<Course>.GetRepo(CoursesDBPath).GetAllObjectsByFilter();
                         foreach (var l in lists)
                         {
                             Console.WriteLine(l.Tests.ToString());
                         }
                         DataGridViewRow newRow = new DataGridViewRow();
                         newRow.CreateCells(table);
                         newRow.Cells[0].Value = student.Username;
                         newRow.Cells[course.Tests.FindIndex(t => t.Id == test.Id) + 1].Value = student.Mark;
                         table.Rows.Add(newRow);
                     }
                 }
             }
         }
         public static void ApplyChangesToDBJournal(DataGridView table, List<Course> courses, Course course)
         {
             foreach (DataGridViewRow row in table.Rows)
             {
                 foreach (DataGridViewCell cell in row.Cells)
                 {
                     foreach (var test in course.Tests)
                     {
                         if (test.Name == cell.OwningColumn.Name)
                         {
                             foreach (var student in test.Students)
                             {
                                 if (row.Cells[0].Value.ToString() == student.Username)
                                 {
                                     if (int.TryParse(cell.Value.ToString(), out int mark))
                                     {
                                         student.Mark = mark;
                                     }
                                 }
                             }
                         }
                     }
                 }
             }
         }

         public static void SendTestAnswers(List<Course> courses, User user, Course course, Test test, List<List<bool>> questions)
         {
             if (user.Role != "Teacher")
             {
                 List<Student> students = test.Students;
                 foreach (var studentCheker in students)
                 {
                     Console.WriteLine(studentCheker.Username);
                     if (studentCheker.Username == user.Username)
                     {
                         MessageBox.Show("You can't pass it twice...", test.Name, MessageBoxButtons.OK);
                         return;
                     }
                 }
                 Student student = new Student(user.Username, user.FirstName, user.LastName);
                 courses.FirstOrDefault(c => c.Id == course.Id).Tests.FirstOrDefault(t => t.Id == test.Id).AddObject(student);

                 for (int i = 0; i < questions.Count; i++)
                 {
                     var question = questions[i];
                     for (int j = 0; j < question.Count; j++)
                     {
                         var answer = question[j];
                         if (answer == true)
                         {
                             courses.FirstOrDefault(c => c.Id == course.Id).Tests.FirstOrDefault(t => t.Id == test.Id).Questions[i].Answers[j].Students.Add(student);
                         }
                     }
                 }
                 MessageBox.Show("Successful! Now wait for assessment...", test.Name, MessageBoxButtons.OK);
                 return;
             }
             MessageBox.Show("You are not student...", test.Name, MessageBoxButtons.OK);
         }*/
    }
}
