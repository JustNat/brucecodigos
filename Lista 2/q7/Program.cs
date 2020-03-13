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
			Console.WriteLine("Digite os coeficientes a, b e c de uma equação do segundo grau");
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			double c = double.Parse(Console.ReadLine());

			double delta = Math.Pow(b, 2) -4 * a * c;
			double x1 = -b + Math.Sqrt(delta) / (2 * a);
			double x2 = -b - Math.Sqrt(delta) / (2 * a);

			if ((x1 % 1 == 0) && (x2 % 1 == 0)) Console.WriteLine($"As raízes são {x1} e {x2}");
			else Console.WriteLine("Impossível calcular");

			Console.ReadKey();


			
			


		}
	}
}
