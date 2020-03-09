using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro horário no formato hh:mm");
            string[] g = Console.ReadLine().Split(':');
            Console.WriteLine("Digite o segundo horário no formato hh:mm");
            string[] h = Console.ReadLine().Split(':');
            int x = int.Parse(g[0]);
            int y = int.Parse(g[1]);
            int w = int.Parse(h[0]);
            int z = int.Parse(h[1]);

            int hora = x + w;
            int minutos = y + z;

            if (minutos >= 60)
            {
                minutos -= 60; 
                hora++;
            }

            Console.WriteLine($"Total de horas = {hora}:{minutos}");
            Console.ReadKey();
                    

                    

               
                    }



            
        
    }
}
