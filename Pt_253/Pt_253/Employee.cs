using System;
using System.Collections.Generic;
using System.Text;

namespace Pt_253
{
    public class Employee : Person
    {
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.id == emp2.id;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.id != emp2.id;
        }

    }
}
