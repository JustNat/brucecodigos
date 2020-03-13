using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do mês");
            int x = int.Parse(Console.ReadLine());

            if (x == 1) Console.WriteLine("O mês de janeiro é do primeiro trimestre do ano");
            if (x == 2) Console.WriteLine("O mês de fevereiro é do primeiro trimestre do ano");
            if (x == 3) Console.WriteLine("O mês de março é do primeiro trimestre do ano");
            if (x == 4) Console.WriteLine("O mês de abril é do segundo trimestre do ano");
            if (x == 5) Console.WriteLine("O mês de maio é do segundo trimestre do ano");
            if (x == 6) Console.WriteLine("O mês de junho é do segundo trimestre do ano");
            if (x == 7) Console.WriteLine("O mês de julho é do terceiro trimestre do ano");
            if (x == 8) Console.WriteLine("O mês de agosto é do terceiro trimestre do ano");
            if (x == 9) Console.WriteLine("O mês de setembro é do terceiro trimestre do ano");
            if (x == 10) Console.WriteLine("O mês de outubro é do quarto trimestre do ano");
            if (x == 11) Console.WriteLine("O mês de novembro é do quarto trimestre do ano");
            if (x == 12) Console.WriteLine("O mês de dezembro é do quarto trimestre do ano");

            Console.ReadKey();
        }
    }
}
