﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public class CourseStudent
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
