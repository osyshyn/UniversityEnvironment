#nullable disable

namespace UniversityEnvironment.Data.Model
{
    public class CourseStudent
    {
        public Guid? CoursesId { get; init; }

        public Course Course { get; init; }

        public Guid? StudentsId { get; init; }

        public Student Student { get; init; }
    }
}
