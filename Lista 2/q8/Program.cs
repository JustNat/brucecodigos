using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 4 valores inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int maior = a;
            int menor = a;
            

            if (a != b && a != c && a != d && b != c && b != d && c != d)
            {
                if (maior < b) maior = b;
                if (maior < c) maior = c;
                if (maior < d) maior = d;
            }
            else Console.WriteLine("Mensagem de erro");

            if (menor > b) menor = b;
            if (menor > c) menor = c;
            if (menor > d) menor = d;

            int soma = (a + b + c + d - (maior + menor));
            


            Console.WriteLine($"Maior valor = {maior}");
            Console.WriteLine($"Menor valor = {menor}");
            Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {soma}");

            Console.ReadKey();



        }
    }
}
