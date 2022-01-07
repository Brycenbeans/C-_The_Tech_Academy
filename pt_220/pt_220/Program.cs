using System;

namespace pt_220
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please enter two parameters");

            Console.WriteLine("First parameter");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second parameter");
            int B = Convert.ToInt32(Console.ReadLine());

            math.MathA(A, B);
            math.MathA(A: 3, B: 5);
            Console.ReadLine();
        }
    }
}
