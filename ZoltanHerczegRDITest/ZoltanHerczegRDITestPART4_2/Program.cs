using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoltanHerczegRDITestPART4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (int x = 2; x <= 100; x++)
            {
                long result = FibonacciCalculationFct(i);
                Console.WriteLine($"{x}.  {result} ");
                i++;
            }
            Console.ReadKey();
        }
        public static int FibonacciCalculationFct(int i)
        {
            if (i == 0)
            {
                return 0;
            }
            else if (i == 1)
            {
                return 1;
            }
            else
            {
                return (FibonacciCalculationFct(i - 1) + FibonacciCalculationFct(i - 2));
            }

        }
    }
}
