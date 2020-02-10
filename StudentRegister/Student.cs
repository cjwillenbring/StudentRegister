using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegister
{
    /// <summary>
    /// Holds the logic for the Student class
    /// </summary>
    public class Student
    {
        private static uint LastWid = 800;

        public uint Wid;

        public string First;

        public string Last;

        public string MI;

        public double GPA { get; }

        private List<CourseResult> courseHistory;

        public Student(string firstName, string lastName, string midInit)
        {
            this.First = firstName;
            this.Last = lastName;
            this.MI = midInit;
            this.Wid = LastWid++;
        }

        public override string ToString()
        {
            return $"{Last}, {First} {MI}";
        }

        public bool EnrollinCourse(Course course)
        {
            var cr = new CourseResult(course, course.CreditHours);
            courseHistory.Add(cr);
            return true;
        }

        public bool DropCourse(Course course)
        {
            var record = courseHistory.Find(x => x.Course == course);
            if (record != null && record.InProgress)
            {
                courseHistory.Remove(record);
                return true;
            }
            return false;
        }

        public bool CompleteCourse(Course course, Grade grade)
        {
            return true;
        }
    }
}
