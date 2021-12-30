using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight: ");
            int packWe = Convert.ToInt32(Console.ReadLine());
            if (packWe > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Package is light enough");
            }

            Console.WriteLine("Please enter the package width: ");
            int packWi = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Please enter the package height: ");
            int packH = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length");
            int packL = Convert.ToInt32(Console.ReadLine());

            if ((packWi + packH + packL) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Package is small enough to qualify");
                Console.ReadLine();
            }

            int total = (packWi * packH * packL * packWe) / 100;
            Console.WriteLine("Your estimated total for shipping the package is: " + total + "$" + " ...maybe FedEx was a bad choice.");
            Console.ReadLine();

        }
    }
}
