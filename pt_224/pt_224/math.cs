using System;
using System.Collections.Generic;
using System.Text;

namespace pt_224
{
    class Math
    {
        public void MathA(int A)
        {
            int result = A / 2;
            Console.WriteLine(result);

        }
        public void MathA(decimal A)
        {
            int result = Convert.ToInt32(A) * 2;
            Console.WriteLine(result);
        }

        public void MathB(out int A)
        {
            A = 55;
            Console.WriteLine(A);
        }
    }
}
