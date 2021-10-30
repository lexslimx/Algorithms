using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class FibonacciSequence
    {
        public FibonacciSequence()
        {

        }

        public int FibBottomUp(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            int[] fibs = new int[n + 1];
            fibs[0] = 0;
            fibs[1] = 1;

            for (var i = 2; i < fibs.Length; i++)
            {
                fibs[i] = fibs[i - 1] + fibs[i - 2];
            }


            return fibs[fibs.Length - 1];
        }

        public int FibTopDown(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return FibTopDown(n - 1) + FibTopDown(n - 2);
        }



    }
}
