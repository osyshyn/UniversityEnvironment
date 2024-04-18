using Newtonsoft.Json;
using UniversityEnvironment.Models;
using UniversityEnvironment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static UniversityEnvironment.Utility.Constants;
using static System.Net.Mime.MediaTypeNames;

namespace UniversityEnvironment.Utility
{
    public static class Predicates
    {

        public static void UpdateTableWithAvailableCourses(DataGridView table, List<Course> courses, User user)
        {
            foreach (var course in courses)
            {
                table.Rows.Add(false, course.Name, course.FacultyName, course.Users);
            }
        }
        public static void UpdateTableWithActualCourses(DataGridView table, List<Course> courses, User user)
        {
            foreach (var course in courses)
            {
                for (int i = 0; i < course.Users.Count; i++)
                {
                    if (user.Username == course.Users[i].Username)
                    {
                        table.Rows.Add(course.Name, course.FacultyName);
                    }
                }
            }
        }
        public static void SignUserOnCourse(DataGridView CoursesTable, List<Course> courses, User user)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if ((bool)CoursesTable.Rows[i].Cells[0].Value == true)
                {
                    var course = courses[i];
                    foreach (var currentUser in course.Users)
                    {
                        if (currentUser.Username == user.Username)
                        {
                            MessageBox.Show("You already signed on some of checked courses...", "Registration", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    course.AddObject(user);
                }
            }
        }
        public static void UnsignUserFromCourse(DataGridView CoursesTable, List<Course> courses, User user)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if ((bool)CoursesTable.Rows[i].Cells[0].Value == true)
                {
                    var course = courses[i];
                    for (int j = course.Users.Count() - 1; j >= 0; j--)
                    {
                        var currentUser = course.Users[j];
                        if (currentUser.Username == user.Username)
                        {
                            course.RemoveObject(currentUser);
                            break;
                        }
                    }
                }
            }
        }
        public static void UpdateTeacherTable(DataGridView table, List<Course> courses, Course course)
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
        }
    }
}
