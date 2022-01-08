using System;
using static pt_231.Person;

namespace pt_231
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample ";
            employee.LastName = "Student";
            employee.SayName();
        }    
    }
}
