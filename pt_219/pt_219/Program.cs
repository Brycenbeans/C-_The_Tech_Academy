using System;
using System.Runtime.InteropServices;

namespace pt_219
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter two numbers one at a time, the second number is optional");
            Console.WriteLine("First number please:");
            int A = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("And the second (if you want)");
                int B = Convert.ToInt32(Console.ReadLine());
                int result = math.MathA(A, B);
                Console.WriteLine(result);
                
            }
            catch
            {
                int result = math.MathA(A);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
