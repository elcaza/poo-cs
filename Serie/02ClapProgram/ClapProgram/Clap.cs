using System;
using System.Collections.Generic;
using System.Text;

namespace ClapProgram
{
	/*
	 * 2. Realizar un programa en el que se le pida al usuario dos números del 1 al 9, num1 y num2. 
	 * Después va a imprimir todos los números naturales del 1 al 100, sin embargo, 
	 * cuando un número sea múltiplo de num1 o num2 o contenga alguno de estos números, va a imprimir ‘clap’. 
	 */
	public static class Clap
    {
		public static void Start()
		{
			try
			{
				Console.WriteLine("Ingresa el primer número");
				int num1 = Convert.ToInt32(Console.ReadLine());
				
				while (num1 < 1 || num1 > 9)
				{
					Console.WriteLine("El número ingresado debe estar entre 1-9 ");
					Console.WriteLine("Ingresa el primer número");
					num1 = Convert.ToInt32(Console.ReadLine());
				}

				Console.WriteLine("Ingresa el segundo numero");
				int num2 = Convert.ToInt32(Console.ReadLine());

				while (num2 < 1 || num2 > 9)
				{
					Console.WriteLine("El número ingresado debe estar entre 1-9 ");
					Console.WriteLine("Ingresa el segundo numero");
					num2 = Convert.ToInt32(Console.ReadLine());
				}

				for (int i = 1; i <= 100; i++)
				{
					if ((i % num1 == 0) || (i % num2 == 0) || i.ToString().Contains(num1.ToString()) || i.ToString().Contains(num2.ToString()))
					{
						Console.WriteLine("clap");
					}
					else
					{
						Console.WriteLine(i);
					}
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("ERROR: Tipo de dato inválido. Ingresa solamente números enteros");
				Start();
			}
		}
	}
}
