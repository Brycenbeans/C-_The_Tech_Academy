using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("String practice");
            Console.ReadLine();
            string a = "one";
            string b = "two";
            string c = "three";
            string concat = a + b + c;
            Console.WriteLine(a + b + c);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Bryce,");
            sb.Append(" and I don't like rice,");
            sb.Append(" my mom says I'm nice,");
            sb.Append(" like george bush can't get fooled twice.");



            Console.WriteLine(sb);
            Console.ReadLine();
            concat = concat.ToUpper();
            Console.WriteLine(concat);
            Console.ReadLine();
        }
    }
}
