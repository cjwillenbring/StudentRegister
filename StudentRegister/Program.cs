using System;
using System.Collections.Generic;

namespace StudentRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Mary", "Contrary", "P"),
                new Student("Blah", "Blah", "B"),
                new Student("Foo", "Bar", "H")
            };

            foreach(Student s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}
