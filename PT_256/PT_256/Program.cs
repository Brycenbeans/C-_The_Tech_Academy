using System;
using System.Collections.Generic;


namespace PT_256
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();

            list1.Add("Bob");
            list1.Add("Bill");
            list1.Add("Bryce");
            list1.Add("Bernard");

            var name = new Employee<string>();
            name.Things = list1;
      
            foreach (string thing in name.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();



            List<int> list2 = new List<int>();
            list2.Add(3);
            list2.Add(4);
            list2.Add(1);
            list2.Add(8);

            var int2 = new Employee<int>();
            int2.Things = list2;

            foreach (int thing in int2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

        }
    }
}
