using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          
            for (int num = 1; num <= n; num++)
            {
                int TotDigits = 0;
                int Digits = num;
                while (Digits > 0)
                {
                    TotDigits += Digits % 10;
                    Digits = Digits / 10;
                }
                bool isSpecial = (TotDigits == 5) || (TotDigits == 7) || (TotDigits == 11);
                Console.WriteLine($"{num} -> {isSpecial}");
                
            }

        }
    }
}
