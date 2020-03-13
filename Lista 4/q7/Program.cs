using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data do aniversário no formato dd/mm");
            string[] x = Console.ReadLine().Split('/');
            int d = int.Parse(x[0]);
            int m = int.Parse(x[1]);

            int max = 0;

            switch (m)
            {
                case 2: max = 29;
                    if (d > max) Console.WriteLine("A data informada é inválida");
                    else Console.WriteLine("A data informada é válida"); break;
                case 4: 
                case 6:
                case 9:
                case 11: max = 30;
                    if (d > max) Console.WriteLine("A data informada é inválida");
                    else Console.WriteLine("A data informada é válida"); break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: max = 31;
                    if (d > 31) Console.WriteLine("A data informada é inválida");
                    else Console.WriteLine("A data informada é válida"); break;

            }


            Console.ReadKey();
        }
    }
}
