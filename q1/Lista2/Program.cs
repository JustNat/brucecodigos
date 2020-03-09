using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y) Console.WriteLine($"Maior:{x}");
                    
            else if (y > x) Console.WriteLine($"Maior:{y}");
                    
            else Console.Write("Números iguais");
                    
            Console.ReadKey();
        }
    }
}
