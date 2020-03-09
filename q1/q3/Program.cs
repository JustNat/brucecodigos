using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro valores inteiros");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int sp = 0;
            int si = 0;

            if (x % 2 == 0) sp += x;
            else si += x;
            if (y % 2 == 0) sp += y;
            else si += y;
            if (w % 2 == 0) sp += w;
            else si += w;
            if (z % 2 == 0) sp += z;
            else si += z;

            Console.WriteLine($"Soma dos pares = {sp}");
            Console.WriteLine($"Soma dos ímpares = {si}");

            Console.ReadKey();



        }
    }
}
