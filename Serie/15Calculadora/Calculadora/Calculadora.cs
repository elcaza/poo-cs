using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
	/*
		15. Crea una calculadora que haga operaciones entre dos números. 
		Las operaciones que deberá soportar serán 
			* suma, 
			* resta, 
			* multiplicación 
			* división. 
		El programa debe de contener un menú que me permita elegir cualquier opción y la última de ellas debe ser para salir. 
		Si se termina una operación debo de volver al menú de inicio. 
		No debe haber forma de salirse del programa a menos que sea con la opción salir. 
		Considerar todas las excepciones posibles e implementarlas para evitar errores en tiempo de ejecución. 
		Considera: 
			* División entre cero, 
			* números demasiado grandes, 
			* cadenas en vez de números, entre otras que a ti se te puedan ocurrir. 
	 */
	public static class Calculadora
	{
	/*
	 * Métodos de Operaciones
	 * */
		public static double Suma(double num1, double num2)
		{
			return num1 + num2;
		}

		public static double Resta(double num1, double num2)
		{
			return num1 - num2;
		}

		public static double Multiplica(double num1, double num2)
		{
			return num1 * num2;
		}

		public static double Divide(double num1, double num2)
		{
			return num1 / num2;
		}

	/*
	 * Función principal de operaciones
	 * */
		public static void Opera(string operacion)
		{
			double number1;
			double number2;

			try
			{
				Console.WriteLine("Dame el primer número a " + operacion + ":");
				number1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Dame el segundo número a " + operacion + ":");
				number2 = Convert.ToInt32(Console.ReadLine());

				switch (operacion)
				{
					case "sumar":
						Console.Clear();
						Console.WriteLine("El resultado de " + number1 + " + " + number2 + " es:");
						Console.WriteLine(Suma(number1, number2));
						break;
					case "restar":
						Console.Clear();
						Console.WriteLine("El resultado de " + number1 + " - " + number2 + " es:");
						Console.WriteLine(Resta(number1, number2));
						break;
					case "multiplicar":
						Console.Clear();
						Console.WriteLine("El resultado de " + number1 + " * " + number2 + " es:");
						Console.WriteLine(Multiplica(number1, number2));
						break;
					case "dividir":
						Console.Clear();
						if (number2 == 0)
						{
							while (number2 == 0)
							{
								Console.Clear();
								Console.WriteLine("No podemos divir números entre cero");
								Console.WriteLine("Dame el primer número a " + operacion + ":");
								number1 = Convert.ToInt32(Console.ReadLine());
								Console.WriteLine("Dame el segundo número a " + operacion + ":");
								number2 = Convert.ToInt32(Console.ReadLine());
							}
						}
						Console.WriteLine("El resultado de " + number1 + " /" + number2 + " es:");
						Console.WriteLine(Divide(number1, number2));
						break;
					default:
						break;
				}
			}
			catch
			{
				Console.Clear();
				Console.WriteLine("Hubo un error, recuerda que: ");
				Console.WriteLine("\tSolamente puedes operar números: ");
				Console.WriteLine("\tNo puedes operar números mayores a nueve digitos: ");
				Console.WriteLine("\tNo puedes hacer divisiones entre cero: \n");
				Opera(operacion);
			}
	
		}
	/*
	 * Función para inicializar la cálculadora
	 */
		public static int Start(int estado=0)
		{
			int exit = 0;

			if (estado == 0)
			{
				Console.WriteLine("\nBienvenido a Calculadora 100% real no fake x270201 rev 1.0");
			}

			Console.WriteLine("\nSelecciona una operación:");

			Console.WriteLine("\tRealizar suma: 1");
			Console.WriteLine("\tRealizar resta: 2");
			Console.WriteLine("\tRealizar multiplicacion: 3");
			Console.WriteLine("\tRealizar división: 4");
			Console.WriteLine("\tSalir: 5");

			try
			{
				int respuesta = Convert.ToInt32(Console.ReadLine());

				switch (respuesta)
				{
					case 1:
						// Console.WriteLine("Suma");
						Opera("sumar");
						break;
					case 2:
						// Console.WriteLine("resta");
						Opera("restar");
						break;
					case 3:
						// Console.WriteLine("Multiplica");
						Opera("multiplicar");
						break;
					case 4:
						// Console.WriteLine("Divide");
						Opera("dividir");
						break;
					case 5:
						Console.WriteLine("Gracias por usar Calculadora 100% real no fake x270201 rev 1.0");
						Console.WriteLine("¡Adiós!");
						Console.WriteLine("Presione cualquier tecla para salir");
						Console.ReadKey();
						return 0;
					default:
						break;
				}
			}
			catch
			{
				Console.Clear();
				Console.WriteLine("Hubo un error, recuerda que: ");
				Console.WriteLine("\tSolamente puedes seleccionar las opciones listadas en el menú: ");
				Console.WriteLine("\tSolamente puedes operar números: ");
			}
			if (exit == 0)
				Start(1);
			return 1;
		}
	}
}
