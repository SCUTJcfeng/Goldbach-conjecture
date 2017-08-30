using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goldbach_coniecture
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 6; i <= 10000; i += 2)
                Goldbach(i);
            Console.ReadLine();
        }

        static void Goldbach(int n)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                if (IsPrime(i) && IsPrime(n - i))
                {
                    Console.WriteLine("{0} = {1} + {2}", n, i, n - i);
                    break;
                }
                if (i == n / 2)
                    Console.WriteLine("{0}不能写成两个素数之和", n);
            }
        }

        static bool IsPrime(int n)
        {
            for (int i = 2; i < Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
