using System;

namespace _14Interfaces
{
    class Program
    {
		/*
		 * Este es un programa que muestra la herencia de interfaces por medio de la clase aves
			 */
        static void Main(string[] args)
		{
			Ave ave1 = new Ave("Aguila");
			Ave ave2 = new Ave("Colibri");
			Ave ave3 = new Ave("Buho");

			presentate(ave1);
			presentate(ave2);
			presentate(ave3);

			Console.WriteLine("Presiones cualquier tecla para salir");
			Console.ReadKey();
		}

		public static void presentate(Ave ave)
		{
			Console.WriteLine("\nHola, soy un {0} tengo {1} Pata(s), {2} Ala(s) y {3} Cola(s)", ave.Nombre, ave.Patas, ave.Alas, ave.Cola);
			
			Console.WriteLine("Yo puedo ");
			ave.Comer();
			
			Console.WriteLine("Y tambien puedo ");
			ave.Volar();
		}
	}
}
