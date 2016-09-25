using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Letters
{
    class TripleLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n-1; i++)
            {
                for (int j = 0; j <= n-1; j++)
                {
                    for (int k = 0; k <= n-1; k++)
                    {
                        char letter0 = (char)('a' + i);
                        char letter1 = (char)('a' + j);
                        char letter2 = (char)('a' + k);
                        Console.WriteLine("{0}{1}{2}", letter0,letter1,letter2);

                    }
                }
            }
        }
    }
}
