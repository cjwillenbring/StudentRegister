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

        public double GPA
        {
            get
            {
                var numerator = 0.0;
                var denominator = 0.0;
                foreach (var cr in courseHistory)
                {
                    if (!cr.InProgress)
                    {
                        numerator += cr.CreditHours * (double)cr.Grade;
                        denominator += cr.CreditHours;
                    }
                }
                return numerator / denominator;
            }
        }

        private List<CourseResult> courseHistory = new List<CourseResult>();

        public Student(string firstName, string lastName, string midInit)
        {
            this.First = firstName;
            this.Last = lastName;
            this.MI = midInit;
            this.Wid = LastWid++;
        }

        public override string ToString()
        {
            return $"{Last}, {First} {MI} ({Wid}) GPA: {GPA}";
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
            var record = courseHistory.Find(x => x.Course == course);
            if (record != null)
            {
                record.InProgress = false;
                record.Grade = grade;
                return true;
            }
            return false;
        }
    }
}
