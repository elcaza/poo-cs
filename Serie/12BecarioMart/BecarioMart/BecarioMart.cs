using System;
using System.Collections.Generic;
using System.Text;

namespace BecarioMart
{
    public static class BecarioMart
    {
        public static void Start()
        {
			// Nombres de los productos y preciosProductos
			List<string> nombresProductos = new List<string>();
			List<double> preciosProductos = new List<double>();
			int opcion;

			Console.WriteLine("BecarioMart v1.0");

			do
			{
				// Menú para ingresar los productos o comprar
				Console.WriteLine("Menú");
				Console.WriteLine("Añadir producto al carrito [1]\nCarrito [2]\nSalir [3]");
				try
				{
					opcion = Convert.ToInt32(Console.ReadLine());
				}
				catch (FormatException fe)
				{
					Console.WriteLine("Ingrese una número");
					opcion = -1;
					continue;
				}

				// Evalua opciones
				switch (opcion)
				{
					case 1:
						Agregar(nombresProductos, preciosProductos);
						break;
					case 2:
						Carrito(nombresProductos, preciosProductos);
						break;
					case 3:
						Console.WriteLine("Gracias por su visita :3");
						Console.ReadKey();
						break;
					default:
						Console.WriteLine("Opción incorrecta");
						Console.ReadKey();
						break;
				}
				Console.Clear();
			} while (opcion != 3);
		}
		public static void Agregar(List<string> nombresProductos, List<double> preciosProductos)
		{
			string producto;
			double costo;
			Console.WriteLine("Nombre del producto");
			producto = Console.ReadLine();
			nombresProductos.Add(producto);

			Console.WriteLine("Precio");
			do
			{
				try
				{
					costo = Convert.ToDouble(Console.ReadLine());
					preciosProductos.Add(costo);
					break;
				}
				catch (FormatException fe)
				{
					Console.WriteLine("Ingrese un número");
					Console.ReadKey();
				}
			} while (true);
		}

		public static void Carrito(List<string> nombresProductos, List<double> preciosProductos)
		{
			int opcion;
			int indice;
			double compraTotal;

			compraTotal = MostrarInformacion(nombresProductos, preciosProductos);

			do
			{
				Console.WriteLine("Comprar[1]\nEliminar productos [2]\nSalir [3]");
				try
				{
					opcion = Convert.ToInt32(Console.ReadLine());
				}
				catch
				{
					Console.WriteLine("Ingrese una número");
					break;
				}
				switch (opcion)
				{
					case 1:
						if (compraTotal >= 500.00)
						{
							Console.WriteLine("No te alcanza");
							Console.ReadKey();
						}
						else
						{
							Console.WriteLine("¡Gracias por su compra, vuelva pronto!");
							Console.ReadKey();
							Environment.Exit(0);
						}
						break;
					case 2:
						Console.WriteLine("Eliminar producto");

						MostrarInformacion(nombresProductos, preciosProductos);
						Console.WriteLine("Indique el producto (mediante el indice) que desea eliminar");
						indice = Convert.ToInt32(Console.ReadLine());
						try
						{
							nombresProductos.RemoveAt(indice);
							preciosProductos.RemoveAt(indice);
							compraTotal = MostrarInformacion(nombresProductos, preciosProductos);
							break;
						}
						catch
						{
							Console.WriteLine("Ocurrio un error");
							Console.ReadKey();
							break;
						}

					case 3:
						Console.WriteLine("¡Gracias por su visita, vuelva pronto!");
						Console.ReadKey();
						break;
					default:
						Console.WriteLine("Opción incorrecta");
						Console.ReadKey();
						break;
				}
				Console.Clear();
			} while (opcion != 3);
		}

		public static double MostrarInformacion(List<string> nombresProductos, List<double> preciosProductos)
		{
			double total = 0;

			for (int i = 0; i < nombresProductos.Count; i++)
			{
				Console.WriteLine("Producto: {0} - Precio: {1} => Indice {2}", nombresProductos[i], preciosProductos[i], i);
				total += preciosProductos[i];
			}

			return total;
		}
	}
}
