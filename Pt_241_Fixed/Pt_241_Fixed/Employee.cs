using System;
using System.Collections.Generic;
using System.Text;

namespace Pt_241_Fixed
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + lastName);
        }

    }
}
