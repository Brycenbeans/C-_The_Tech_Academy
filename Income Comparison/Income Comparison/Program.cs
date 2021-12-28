using System;

namespace Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymouse Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int Person1Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int Person1Hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int Person2Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int Person2Hours = Convert.ToInt32(Console.ReadLine());

            int AnnualSalaryP1 = Person1Hours * Person1Rate * 52;
            int AnnualSalaryP2 = Person2Hours * Person2Rate * 52;

            Console.Write("Person 1 makes: ");
            Console.Write(AnnualSalaryP1.ToString());
            Console.ReadLine();
            Console.Write("Person 2 makes: ");
            Console.Write(AnnualSalaryP2.ToString());
            Console.ReadLine();

            Console.Write("Does Person 1 make more money than Person 2? ");
            Console.ReadLine();
            bool compare = AnnualSalaryP1 > AnnualSalaryP2;
            Console.Write(compare.ToString());
        }
    }
}
