using System;
using System.Collections.Generic;
using System.Text;

namespace PT_241
{
    public class Employee : Person
    {
        public void SayName()
        {
            Console.WriteLine(firstName + lastName);
        }
    }
}
