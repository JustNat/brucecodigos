using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());

            if ((x + y) > w && (x + w) > y && (y + w) > x && x != y && x != w && y != w) Console.WriteLine("Triângulo escaleno");
            else if ((x + y) > w && (x + w) > y && (y + w) > x && x == y || x == w || w == y) Console.WriteLine("Triângulo isósceles");
            else if ((x + y) > w && (x + w) > y && (y + w) > x && x == y && x == w && w == y) Console.WriteLine("Triângulo equilátero");
            else Console.WriteLine("Esses valores não formam um triângulo");

            Console.ReadKey();


        }
    }
}
