using System;

namespace C_Sharp_Switch
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;
            while (!isGuessed)
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62 try again");
                        Console.WriteLine("Guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29 try again");
                        Console.WriteLine("Guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55 try again");
                        Console.WriteLine("Guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. Nice!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("Guess again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            
            Console.Read();
        }
    }
}
