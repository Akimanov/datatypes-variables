using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                var SumOfDigits = 0;
                int digits = num;

                while ( digits > 0)
                {
                    SumOfDigits += digits % 10;
                    digits = digits / 10;

                }
                bool isSpecial = (SumOfDigits == 5) || (SumOfDigits == 7) || (SumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", num, isSpecial);
            }
        }
    }
}
