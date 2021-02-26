using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTasks
{
    public class Employee<T>
    {
        public T ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public float Salary { get; set; }


        public Employee(T id, string name, string department, float salary)
        {
            ID = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Employee { ID }: { Name } is in the { Department } department and is paid a salary of { Convert.ToString(Salary) }";
        }


    }
}
