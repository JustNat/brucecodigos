﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
            string[] x = Console.ReadLine().Split('/');
            int d = int.Parse(x[0]);
            int m = int.Parse(x[1]);
            int a = int.Parse(x[2]);

            string mes = "coco";

            if (m == 1) mes = "janeiro";
            else if (m == 2) mes = "fevereiro";
            else if (m == 3) mes = "março";
            else if (m == 4) mes = "abril";
            else if (m == 5) mes = "maio";
            else if (m == 6) mes = "junho";
            else if (m == 7) mes = "julho";
            else if (m == 8) mes = "agosto";
            else if (m == 9) mes = "setembro";
            else if (m == 10) mes = "outubro";
            else if (m == 11) mes = "novembro";
            else if (m == 12) mes = "dezembro";

            Console.WriteLine($"A data é {d} de {mes} de {a}");

            Console.ReadKey();


        }
    }
}
