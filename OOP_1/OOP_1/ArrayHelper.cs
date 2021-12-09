using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class ArrayHelper
    {
        public static int[] Fibonacci(int n)
        {
            int[] F = new int[n];
            F[0] = 0;
            if (n == 0) return F;
            F[1] = 1;
            if (n == 1) return F;
            int i = 1;

            while (F[i] <= n)
            {
                i++;
                F[i] = F[i - 1] + F[i - 2];

            }
            return F;
        }
    }
}
