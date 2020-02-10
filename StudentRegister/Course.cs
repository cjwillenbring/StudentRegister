using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegister
{
    public class Course : IEquatable<Course>
    {
        public uint Number;

        public uint CreditHours;

        public string Name;

        public string Semester;

        public List<Student> Students;

        public bool Equals(Course other)
        {
            return other.Number == Number;
        }
    }
}
