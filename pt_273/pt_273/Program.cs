using System;
using System.Collections.Generic;

namespace pt_273
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>
            {
                new Employee {FirstName="Joe", LastName="Mama", ID=0},
                new Employee {FirstName="Joe", LastName="Daddy", ID=1},
                new Employee {FirstName="Bob", LastName="Fdas", ID=2},
                new Employee {FirstName="Bill", LastName="FDSF", ID=3},
                new Employee {FirstName="Bernard", LastName="ADS", ID=4},
                new Employee {FirstName="Brenda", LastName="Fasd", ID=5},
                new Employee {FirstName="Brianna", LastName="Gasd", ID=6},
                new Employee {FirstName="Bryce", LastName="Dasda", ID=7},
                new Employee {FirstName="Beverley", LastName="Hdfasd", ID=8},
                new Employee {FirstName="Brian", LastName="Hadsada", ID=9}
            };
            List<string> Duplicates = new List<string>();

            foreach (Employee Emp in employee)
            {
                if (Emp.FirstName == "Joe")
                {
                    Duplicates.Add(Emp.FirstName + " " + Emp.LastName + " " + Emp.ID);                  
                }

            }
            foreach (string Dup in Duplicates)
            {
                Console.WriteLine(Dup);
            }

            List<Employee> Dup1 = employee.FindAll(x => x.FirstName == "Joe");

            foreach (Employee Emp1 in Dup1)
            {
                Console.WriteLine(Emp1.FirstName + " " + Emp1.LastName + " " + Emp1.ID);
            }

            List<Employee> Dup2 = employee.FindAll(x => x.ID > 5);

            foreach (Employee Emp2 in Dup2)
            {
                Console.WriteLine(Emp2.FirstName + " " + Emp2.LastName + " " + Emp2.ID);
            }
        }
        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }

        }
    }
}
