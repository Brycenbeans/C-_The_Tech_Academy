using System;
using System.Collections.Generic;
using System.Text;

namespace pt_231
{
    public class Person 
    {
        public string FirstName;
        public string LastName;
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }

    }
    public class Employee : Person
    {
        public int Id;
    }

}
