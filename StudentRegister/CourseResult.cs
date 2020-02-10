using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegister
{
    public class CourseResult
    {
        public Course Course;

        public uint CreditHours;

        public Grade Grade;

        public bool InProgress;

        public CourseResult(Course course, uint creditHours)
        {
            this.Course = course;
            this.CreditHours = creditHours;
            this.InProgress = true;
        }
    }
}
