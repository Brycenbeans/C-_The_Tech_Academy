using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleAppPartSix_pg_196
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Bryce", "Daniel", "Blake", "Brandon", "Bryce" };
            foreach (string name in names)
            {
                Console.WriteLine(names[0]);
                Console.WriteLine(names[1]);
                Console.WriteLine(names[2]);
                Console.WriteLine(names[3]);
                Console.WriteLine(names[4]);
                if (names[0] == names[1] || names[0] == names[2] || names[0] == names[3] || names[0] == names[4])
                {
                    Console.WriteLine("Bryce is a duplicate");
                    break;
                }
                if (names[1] == names[0] || names[1] == names[2] || names[1] == names[3] || names[1] == names[4])
                {
                    Console.WriteLine("Daniel is a duplicate");
                    break;
                }
                if (names[2] == names[0] || names[2] == names[1] || names[2] == names[3] || names[2] == names[4])
                {
                    Console.WriteLine("Blake is a duplicate");
                    break;
                }
                if (names[3] == names[0] || names[3] == names[1] || names[3] == names[2] || names[3] == names[4])
                {
                    Console.WriteLine("Brandon is a duplicate");
                    break;
                }
                if (names[4] == names[0] || names[4] == names[1] || names[4] == names[2] || names[4] == names[3])
                {
                    Console.WriteLine("Bryce is a duplicate");
                    break;
                }
            }
        }
    }
}
