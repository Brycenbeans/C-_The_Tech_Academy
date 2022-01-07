using System;
using System.Collections.Generic;
using System.Text;

namespace Pt_218
{
    class Math
    {
        public int MathA(int A)
        {
            int result = A + 5;
            return result;
        }

        public int MathA(decimal A)
        {
            int X = Convert.ToInt32(A);
            int result1 = X * 5;
            return result1;
        }

        public int MathA(string A)
        {        
            int result2 = Convert.ToInt32(A) + 7;          
            return result2;
        }

    }
}
