using System;
using System.Collections.Generic;
using System.Text;
/*
 * 1. Programa que permite calcular la suma de los primeros n números naturales, siendo n un número natural ingresado por el usuario. 
	 */
namespace Sumatoria_N
{
	static class SumatoriaToN
	{
		public static void Start()
		{
			try
			{
				Console.WriteLine("Dame el número hasta el que se hará la sumatoria: ");
				int number = Convert.ToInt32(Console.ReadLine());
				int suma = 0;

				if (number < 0)
				{
					Console.WriteLine("Dato de ingreso no válido: ");
					Console.WriteLine("\tEl dato debe ser un número mayor a cero.");
					Console.WriteLine("\tEl dato no debe ser demasiado grande. \n");
					Start();
				}

				for (int i=1; i <= number; i++)
				{
					suma += i;
				}
				Console.WriteLine("La sumatoria de {0} es {1}", number, suma);
			}
			catch
			{
				Console.WriteLine("Dato de ingreso no válido: ");
				Console.WriteLine("\tEl dato debe ser un número mayor a cero.");
				Console.WriteLine("\tEl dato no debe ser demasiado grande. \n");

				Start();
			}
		}
	}
}
