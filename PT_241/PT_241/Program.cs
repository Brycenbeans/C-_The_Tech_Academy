using System;

namespace PT_241
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
            employee.Quit();
            Console.ReadLine();


            IQuittable IQuit = new Employee();
            IQuit.Quit();
        }
        
    }
}
