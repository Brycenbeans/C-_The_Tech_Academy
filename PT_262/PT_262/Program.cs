using System;

namespace PT_262
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week");
            string CurrentDay = Console.ReadLine();
            try
            {
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), CurrentDay);          
                Console.WriteLine(day + " is a valid day");
                
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, but " + CurrentDay + "is not a valid day, no soup for you");
            }
            
        }
    }
}
