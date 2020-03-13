using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro valores inteiros");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());

            int media = (x + y + w + z) / 4;
            Console.WriteLine($"Média = {media}");
            Console.WriteLine("Números menores que a média");
            if (x < media) Console.WriteLine($"{x}");
            if (y < media) Console.WriteLine($"{y}");
            if (z < media) Console.WriteLine($"{z}");
            if (w < media) Console.WriteLine($"{w}");

            Console.WriteLine("Números maiores ou iguais à média");
            if (x > media) Console.WriteLine($"{x}");
            if (y > media) Console.WriteLine($"{y}");
            if (z > media) Console.WriteLine($"{z}");
            if (w > media) Console.WriteLine($"{w}");

            Console.ReadKey();
        }
    }
}
