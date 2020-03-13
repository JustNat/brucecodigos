using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros separados por um operador +,-,* ou /");
            char[] coco = { '+', '-', '*', '/' };
            string y = Console.ReadLine();
            string[] x = y.Split(coco);
            int a = int.Parse(x[0]);
            int b = int.Parse(x[1]);

            if (y.Contains('+')) Console.WriteLine($"O resultado da operação é {a + b}");
            else if (y.Contains('-')) Console.WriteLine($"O resultado da operação é {a - b}");
            else if (y.Contains('*')) Console.WriteLine($"O resultado da operação é {a * b}");
            else if (y.Contains('/')) Console.WriteLine($"O resultado da operação é {a / b}");

            Console.ReadKey();


            
        }
    }
}
