using System;
using System.Collections.Generic;

namespace Pt_253
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                firstName = "Mike ",
                lastName = "Wazowski",
                id = 1
            };

            Employee employee2 = new Employee()
            {
                firstName = "John ",
                lastName = "Cena",
                id = 2
            };

            Console.WriteLine(employee1 == employee2);
        }             
    }
}
