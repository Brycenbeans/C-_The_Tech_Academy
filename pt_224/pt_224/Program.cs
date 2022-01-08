using System;

namespace pt_224
{
    static class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Choose a number to divide by 2");
            int UserNumb = Convert.ToInt32(Console.ReadLine());
            math.MathA(UserNumb);

            Console.WriteLine("Choose a number to multiply by 2");
            decimal UserNumb2 = Convert.ToDecimal(Console.ReadLine());
            math.MathA(UserNumb2);

            int initializeD;
            math.MathB(out initializeD);
            Console.ReadLine();

        }
    }
}
