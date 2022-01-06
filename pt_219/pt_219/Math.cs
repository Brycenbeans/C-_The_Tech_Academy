using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace pt_219
{
    class Math
    {
        public int MathA(int A, [Optional]int B)
        {
            int result = A + B;
            return result;
        }
    }
}
