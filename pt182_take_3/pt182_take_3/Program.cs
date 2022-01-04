using System;
using System.Collections.Generic;
namespace pt182_take_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "dog", "cat", "mouse" };
            Console.WriteLine("Please select: 0, 1, or 2 to display the string");
            int Select = int.Parse(Console.ReadLine());
            if (Select < 0 || Select > 2)
            {
                Console.WriteLine("Input is invalid");
            }
            else
            {
                Console.WriteLine(stringArray[Select]);
            }

            Console.ReadLine();


            int[] numArray = { 1, 3, 5 };
            Console.WriteLine("Please select: 0, 1, or 2 to display the integer");
            int SelectNum = int.Parse(Console.ReadLine());
            if (Select < 0 || Select > 2)
            {
                Console.WriteLine("Input is invalid");
            }
            else
            {
                Console.WriteLine(numArray[SelectNum]);
            }
            Console.ReadLine();

            List<string> list = new List<string>(3)
            {
                "Bob",
                "Bill",
                "Barney"
            };

            Console.WriteLine("Please select: 0, 1, or 2 to display the string from list");
            int SelectList = int.Parse(Console.ReadLine());
            if (SelectList < 0 || SelectList > 2)
            {
                Console.WriteLine("Input is invalid");
            }
            else
            {
                Console.WriteLine(list[SelectList]);
            }
            Console.ReadLine();
        }
    }
}
