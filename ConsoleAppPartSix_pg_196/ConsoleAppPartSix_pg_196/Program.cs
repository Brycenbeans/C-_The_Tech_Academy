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
            List<string> names1 = new List<string>();
            foreach (string name in names)
            {
                bool whatever = false;
                string msg = name;
                foreach(string name1 in names1)
                {                  
                    if (name == name1)
                    {
                        whatever = true;
                    }                                                                              
                }
                if (whatever == true)
                {
                    msg += " has been seen before";
                }
                else
                {
                    msg += " has not been seen before";
                }
                names1.Add(name);
                Console.WriteLine(msg);           
            }
        }
    }
}
