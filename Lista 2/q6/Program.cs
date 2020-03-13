using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores inteiros");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());

            int menor = x;
            if (y < menor) menor = y;
            if (w < menor) menor = w;

            int maior = x;
            if (y > maior) maior = y;
            if (w > maior) maior = w;

            int soma = maior + menor;

            Console.WriteLine($"A soma do maior número com o menor número é {soma}");
            

            Console.ReadKey();
            
        }
    }
}
