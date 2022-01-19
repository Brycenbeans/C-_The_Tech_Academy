using System;
using System.IO;

namespace PT_307
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            DateTime today = DateTime.Now;
            DateTime whenTime = today.AddHours(userNumber);
            Console.WriteLine(whenTime);
        }
    }
}
