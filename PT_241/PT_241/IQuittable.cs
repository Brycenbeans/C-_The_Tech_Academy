using System;
using System.Collections.Generic;
using System.Text;

namespace PT_241
{
    public interface IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I quit");
        }
    }
}
