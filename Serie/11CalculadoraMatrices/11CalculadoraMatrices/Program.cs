using System;

namespace _11CalculadoraMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
			int size;
			Console.WriteLine("Escribe el tamaño de las matrices cuadradas (nxn)\nn: ");
			size = Convert.ToInt32(Console.ReadLine());

			Console.Clear();
			Console.WriteLine("Valores de Matriz 1:");

			// Creamos una matriz
			double[,] matriz1 = new double[size, size];

			MatrizNxN.AsignaValores(ref matriz1);

			Console.Clear();
			Console.WriteLine("Valores de Matriz 2:");

			double[,] matriz2 = new double[size, size];
			MatrizNxN.AsignaValores(ref matriz2);

			int respMenu = MatrizNxN.Menu();

			Console.Clear();
			Console.WriteLine("Matriz 1:");
			MatrizNxN.MuestraValores(ref matriz1);

			Console.WriteLine("Matriz 2:");
			MatrizNxN.MuestraValores(ref matriz2);
			Console.WriteLine();

			// Evalua el valor almacenado en la variable respMenu
			switch (respMenu)
			{
				case 1:
					Console.WriteLine("Resultado de la suma de matrices:");
					MatrizNxN.SumaMatrices(ref matriz1, ref matriz2);
					break;
				case 2:
					Console.WriteLine("Resultado de la resta de matrices");
					MatrizNxN.RestaMatrices(ref matriz1, ref matriz2);
					break;
				case 3:
					Console.WriteLine("Resultado de la multiplicacion de matrices");
					MatrizNxN.MultiplicaMatrices(ref matriz1, ref matriz2);
					break;
			}
			Console.WriteLine("Presione cualquier tecla para salir");
			Console.ReadKey();
		}
    }
}
