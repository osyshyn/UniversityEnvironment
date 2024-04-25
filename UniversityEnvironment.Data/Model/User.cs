using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public class User : EnvironmentObject
    {
        private string? _username;
        private string? _firstName;
        private string? _lastName;
        private string? _password;
        private string? _role;
        private List<Course>? _courses;

        public string? Username { get => _username; set => _username = value; }
        public string? FirstName { get => _firstName; set => _firstName = value; }
        public string? LastName { get => _lastName; set => _lastName = value; }
        public string? Password { get => _password; set => _password = value; }
        public string? Role { get => _role; set => _role = value; }
        public List<Course>? Courses { get => _courses; set => _courses = value; }
    }
}
