using System;

namespace Pt_241_Fixed
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample ";
            employee.lastName = "Student";
            employee.SayName();
            Console.ReadLine();
        }

    }
}
