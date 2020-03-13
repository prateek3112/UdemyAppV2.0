﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyWebApp.Models
{
    public interface ICourseRepository
    {
        IEnumerable<Course> Courses { get; }
        Course GetCourseById(int CourseId);
        IEnumerable<Course> CourseOfTheWeek { get; }
    }
}
