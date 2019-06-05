using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoltanHerczegRDITestPART4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStr = Console.ReadLine();
            if (inputStr.All(char.IsDigit))
            {
                if (inputStr == "0")
                {
                    Console.WriteLine($"{inputStr} is not odd/even! ");
                }
                else
                {
                    Console.WriteLine(OddOrEvenStr(inputStr));
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.ReadKey();
        }
        static public string OddOrEvenStr(string inputStr)
        {
            string resultOddOrEven = "";
            char last = inputStr[inputStr.Length - 1];
            switch (last)
            {
                case '0':
                    resultOddOrEven = "Even";
                    break;
                case '2':
                    resultOddOrEven = "Even";
                    break;
                case '4':
                    resultOddOrEven = "Even";
                    break;
                case '6':
                    resultOddOrEven = "Even";
                    break;
                case '8':
                    resultOddOrEven = "Even";
                    break;
                default:
                    resultOddOrEven = "Odd";
                    break;
            }
            return resultOddOrEven;
        }
    }
}
