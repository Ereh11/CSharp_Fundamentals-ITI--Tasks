using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class Math
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtact(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            if(y == 0)
                return x;

            return x / y;
        }
    }
}
