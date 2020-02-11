using System;
using System.Collections.Generic;
using System.Text;

namespace _11CalculadoraMatrices
{
	/*
	 * 11. Elabora un programa que simule una calculadora de matrices (utilizando arreglos bidimensionales). El tamaño de la matriz (arreglo) deberá ser ingresado por el usuario, así como los valores contenidos en ella. En este caso sólo se soportarán matrices cuadradas (nxn). Las operaciones que deberá contender la calculadora son: suma resta multiplicación Se puede utilizar cualquier tipo de dato (int, double, oat). El programa debe contener un menú que me permita elegir entre las operaciones de la calculadora y cuando se hagan las operaciones, me debe mostrar las matrices que operan, así como el resultado. Estas matrices deben mostrarse en su respectivo formato, es decir, cuadradas. Sin importar lo que el usuario ingrese el programa no debe "morir", usen excepciones para controlar el ingreso de datos del usuario. 
	 */
	class MatrizNxN
    {
		static public void AsignaValores(ref double[,] matriz)
		{
			for (int i = 0; i < Math.Sqrt(matriz.Length); i++)
			{
				for (int j = 0; j < Math.Sqrt(matriz.Length); j++)
				{
					int ban = 0;
					// Validacion de los valores ingresados
					do
					{
						try
						{
							Console.WriteLine("Ingrese el valor [{0},{1}]", i, j);
							matriz[i, j] = Convert.ToDouble(Console.ReadLine());
							ban = 1;
						}
						catch
						{
							Console.WriteLine("Ingrese un valor valido >:c");
						}
					} while (ban == 0);

				}
			}
		}

		static public void MuestraValores(ref double[,] matriz)
		{
			double size = Math.Sqrt(matriz.Length);
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Console.Write(" " + matriz[i, j]);
				}
				Console.WriteLine();
			}
		}
		static public void SumaMatrices(ref double[,] m1, ref double[,] m2)
		{
			double size = Math.Sqrt(m1.Length);
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Console.Write(" " + (m1[i, j] + m2[i, j]));
				}
				Console.WriteLine();
			}
		}

		static public void RestaMatrices(ref double[,] m1, ref double[,] m2)
		{
			double size = Math.Sqrt(m1.Length);
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Console.Write(" " + (m1[i, j] - m2[i, j]));
				}
				Console.WriteLine();
			}
		}

		static public void MultiplicaMatrices(ref double[,] m1, ref double[,] m2)
		{
			double resultado;
			double size = Math.Sqrt(m1.Length);
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					resultado = 0;
					for (int k = 0; k < size; k++)
					{
						resultado += m1[i, k] * m2[k, j];
					}
					Console.Write(" " + resultado);
				}
				Console.WriteLine();
			}
		}
		static public int Menu()
		{
			Console.Clear();
			Console.WriteLine("Seleccione una opcion:");
			Console.WriteLine("\tSuma: 1");
			Console.WriteLine("\tResta: 2");
			Console.WriteLine("\tMultiplicacion: 3");
			Console.Write("Opcion: ");
			return Convert.ToInt32(Console.ReadLine());
		}
	}
}
