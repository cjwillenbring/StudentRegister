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

            var cis501 = new Course()
            {
                CreditHours = 3,
                Name = "CIS 501",
                Number = 654321789,
            };

            var cis400 = new Course()
            {
                CreditHours = 3,
                Name = "CIS 400",
                Number = 879564312,
            };

            var cis308 = new Course()
            {
                CreditHours = 1,
                Name = "CIS 308",
                Number = 879789312,
            };

            var x = new Student("Minnie", "Mouse", "M");
            x.EnrollinCourse(cis308);
            x.EnrollinCourse(cis400);
            x.EnrollinCourse(cis501);

            x.CompleteCourse(cis308, Grade.B);
            x.CompleteCourse(cis400, Grade.A);
            x.DropCourse(cis501);

            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(x);
        }
    }
}
