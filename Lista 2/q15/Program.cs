using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int menor = a;
            int maior = a;
            int medio = a;

            if (b < menor) menor = b;
            else if (c < menor) menor = c;
            if (b > maior) maior = b;
            else if (c > maior) maior = c;
            if (b > menor && b < maior) medio = b;
            else if (c > menor && c < maior) medio = c;

            Console.WriteLine($"{menor}, {medio}, {maior}");

            Console.ReadKey();


        }
    }
}
