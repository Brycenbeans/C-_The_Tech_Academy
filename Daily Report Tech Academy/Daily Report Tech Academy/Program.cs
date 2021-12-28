using System;

namespace Daily_Report_Tech_Academy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You are studying: " + courseName);

            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are page number: " + pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Thanks for this input: " + positiveExp);

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("You wrote: " + feedBack + " thanks for that!");

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hS = Convert.ToInt32(hoursStudied);

            Console.Write("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
        }
    }
}
