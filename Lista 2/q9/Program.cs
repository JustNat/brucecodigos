using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o horário no formato hh:mm");
            string[] x = Console.ReadLine().Split(':');
            int h = int.Parse(x[0]);
            int m = int.Parse(x[1]);

            int angulo = ((11 * m) - (60 * h)) / 2;

            if (h > 12 || m > 59) Console.WriteLine("Hora inválida");
            else Console.WriteLine($"Menor ângulo entre os ponteiros = {angulo} graus");

            Console.ReadKey();




            
        }
    }
}
