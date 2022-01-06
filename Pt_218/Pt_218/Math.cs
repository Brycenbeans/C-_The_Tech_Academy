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

        public decimal MathA(decimal A)
        {
            decimal result1 = A * 5;
            return result1;
        }

        public string MathA(string A)
        {
            int result2 = Convert.ToInt32(A) + 7;
            string result3 = Convert.ToString(result2);
            return result3;
        }

    }
}
