using System;
using System.Collections.Generic;
using System.Text;

namespace Pt_241_Fixed
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();

    }
}
