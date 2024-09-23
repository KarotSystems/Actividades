using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorizar
    {
        public static int FactorialIF(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * FactorialIF(n - 1);
            }
        }
        public static int FactorialFor(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static int FactorialDoWhile(int n)
        {
            int factorial = 1;
            int i = 1;
            do
            {
                factorial *= i;
                i++;
            } while (i <= n);
            return factorial;
        }
        public static int FactorialWhile(int n)
        {
            int factorial = 1;
            int i = 1;
            while (i <= n)
            {
                factorial *= i;
                i++;
            }
            return factorial;
        }
    }
}
