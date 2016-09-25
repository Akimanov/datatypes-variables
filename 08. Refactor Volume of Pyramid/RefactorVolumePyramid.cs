using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Refactor_Volume_of_Pyramid
{
    class RefactorVolumePyramid
    {
        static void Main(string[] args)
        {
            double Lenght, Width, Height, Volume = 0.0;
            //Console.Write("Length: ");
            Lenght = double.Parse(Console.ReadLine());
            //Console.Write("Width: ");
            Width = double.Parse(Console.ReadLine());
            //Console.Write("Heigth: ");
            Height = double.Parse(Console.ReadLine());
            Volume = ((Lenght * Width) / 3 * Height);
            Console.WriteLine("Length: Width: Height: Pyramid Volume: {0:F2}", Volume);

        }
    }
}
