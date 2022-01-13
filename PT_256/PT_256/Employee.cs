using System;
using System.Collections.Generic;
using System.Text;

namespace PT_256
{
    public class Employee<T>
    {
        public string Name { get; set; }
        public List<T> Things { get; set; }

    }
}
