using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Fibonacci
    {
        public static int FiboFor(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int a = 0;
            int b = 1;
            int resultado = 0;
            for (int i = 2; i <= n; i++)
            {
                resultado = a + b;
                a = b;
                b = resultado;
            }
            return resultado;
        }
        public static int FiboDoWhile(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int x = 2;
            int a = 0;
            int b = 1;
            int resultado = 0;
            do
            {
                resultado = a + b;
                a = b;
                b = resultado;
                x++;
            }
            while (x<=n);
            return resultado;
        }
        public static int FiboWhile(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int x = 2;
            int a = 0;
            int b = 1;
            int resultado = 0;
            while (x <= n)
            {
                resultado = a + b;
                a = b;
                b = resultado;
                x++;
            }
            return resultado;
        }
    }
}
