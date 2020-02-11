using System;

namespace _14Interfaces
{
    class Program
    {
		/*
		 * Este es un programa muestra los 4 pilares de POO
		 * Abstracción al hacer este proceso y pasarlo a clases
		 * Herencia por parte de las clases
		 * Polimorfismo por parte de las clases y su método caminar y volar en andar
		 * Encapsulamimento ya que saldría un error si se quiere alcanzar un atributo fuera de la clase
		 * 
			 */
        static void Main(string[] args)
		{
			Ave ave1 = new Ave("Aguila");
			Ave ave2 = new Ave("Colibri");
			Ave ave3 = new Ave("Buho");

			Perro perro1 = new Perro("Maltes");
			Perro perro2 = new Perro("Akita");
			Perro perro3 = new Perro("Solobino");

			presentate(ave1);
			presentate(ave2);
			presentate(ave3);

			presentate(perro1);
			presentate(perro2);
			presentate(perro3);

			Console.WriteLine("Presione cualquier tecla para salir");
			Console.ReadKey();
		}

		public static void presentate(Ave ave)
		{
			Console.WriteLine("\nHola, soy un {0} tengo {1} Pata(s), {2} Ala(s) y {3} Cola(s)", ave.Nombre, ave.Patas, ave.Alas, ave.Cola);
			
			Console.WriteLine("Yo puedo ");
			ave.Comer();
			
			Console.WriteLine("Y tambien puedo ");
			ave.Andar();
		}

		public static void presentate(Perro perro)
		{
			Console.WriteLine("\nHola, soy un {0} tengo {1} Pata(s), {2} Cola(s)", perro.Nombre, perro.Patas, perro.Cola);

			Console.WriteLine("Yo puedo ");
			perro.Comer();

			Console.WriteLine("Y tambien puedo ");
			perro.Andar();
		}
	}
}
