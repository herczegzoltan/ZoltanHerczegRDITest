using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoltanHerczegRDITestPART4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string inputStr = input.ToString();
            string newNumberStr = "";

            for (int i = 0; i < inputStr.Length; i++)
            {
                newNumberStr += inputStr[inputStr.Length - i - 1];
            }

            Console.WriteLine(newNumberStr);
            Console.ReadLine();
        }
    }
}
