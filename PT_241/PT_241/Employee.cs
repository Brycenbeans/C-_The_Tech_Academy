using System;
using System.Collections.Generic;
using System.Text;

namespace PT_241
{
    public class Employee : Person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine(firstName + lastName);
        }

        internal void Quit()
        {
            Console.WriteLine("I quit");
        }
    }
}
