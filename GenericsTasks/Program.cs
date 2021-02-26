using System;
using System.Collections.Generic;

namespace GenericsTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudyCourse> courses = new List<StudyCourse>
            {
                new StudyCourse{ CourseId = 1, CourseName = "Mathematics", Description = "Learn the basics of maths" },
                new StudyCourse{ CourseId = 2, CourseName = "English", Description = "The basics of grammar" },
                new StudyCourse{ CourseId = 3, CourseName = "Science", Description = "Learn with Prof Einstein" }
            };


            List<Employee<int>> salesEmpList = new List<Employee<int>> 
            { 
                new Employee<int>(1,"Fred Flintstone","Sales", 35000F),
                new Employee<int>(2, "Barney Rubble", "Sales", 41000F),
                new Employee<int>(3, "Brock Stone", "Sales", 50000F)
            };

            List<Employee<string>> marketingEmpList = new List<Employee<string>>
            {
                new Employee<string>("WILFL", "Wilma Flintstone", "Marketing", 40000F),
                new Employee<string>("BETRU", "Betty Rubble", "Marketing", 40000F),
                new Employee<string>("ANNMA", "Anne Marrock", "Marketing", 45000F)
            };


            Console.WriteLine("Sales Department Staff:");

            foreach (Employee<int> employee in salesEmpList)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("Marketing Department Staff:");

            foreach (Employee<string> employee in marketingEmpList)
            {
                Console.WriteLine(employee);
            }


            Console.Read();
        }
    }
}
