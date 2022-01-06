using System;

namespace Pt_215
{
    class Program
    {
        static void Main(string[] args)
        {
            Math Math = new Math();
            //calling method one to multiply by 5
            Console.WriteLine("What number would you like to do math operations on?");
            int One = Convert.ToInt32(Console.ReadLine());
            int whatever = Math.Math1(One);
            Console.WriteLine(whatever);
            Console.ReadLine();

            //calling method one to multiply by 10
            Console.WriteLine("What number would you like to do math operations on?");
            int Two = Convert.ToInt32(Console.ReadLine());
            int whatever2 = Math.Blah(Two);
            Console.WriteLine(whatever2);
            Console.ReadLine();

            //calling method one to multiply by 20
            Console.WriteLine("What number would you like to do math operations on?");
            int Three = Convert.ToInt32(Console.ReadLine());
            int whatever3 = Math.BlahBlah(Three);
            Console.WriteLine(whatever3);
            Console.ReadLine();




        }
    }
}
