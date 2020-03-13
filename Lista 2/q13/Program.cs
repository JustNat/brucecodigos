using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dez valores inteiros");
            string[] x = Console.ReadLine().Split(' ');
            int a = int.Parse(x[0]);
            int b = int.Parse(x[1]);
            int c = int.Parse(x[2]);
            int d = int.Parse(x[3]);
            int e = int.Parse(x[4]);
            int f = int.Parse(x[5]);
            int g = int.Parse(x[6]);
            int h = int.Parse(x[7]);
            int i = int.Parse(x[8]);
            int j = int.Parse(x[9]);

            int maior = a;
            int menor = a;

            if (b > maior) maior = b;
            if (c > maior) maior = c;
            if (d > maior) maior = d;
            if (e > maior) maior = e;
            if (f > maior) maior = f;
            if (g > maior) maior = g;
            if (h > maior) maior = h;
            if (i > maior) maior = i;
            if (j > maior) maior = j;

            if (b < menor) menor = b;
            if (c < menor) menor = c;
            if (d < menor) menor = d;
            if (e < menor) menor = e;
            if (f < menor) menor = f;
            if (g < menor) menor = g;
            if (h < menor) menor = h;
            if (i < menor) menor = i;
            if (j < menor) menor = j;

            Console.WriteLine($"O maior valor é {maior} e o menor é {menor}");

            Console.ReadKey();
        }
    }
}
