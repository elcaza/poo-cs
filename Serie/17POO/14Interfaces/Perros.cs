using System;
using System.Collections.Generic;
using System.Text;

namespace _14Interfaces
{
	public class Perros : Interface_Animal
	{
		public int Patas = 4;
		public int Cola = 1;
		public string Nombre { get; private set; }
		public Perros(string nombre)
		{
			this.Nombre = nombre;
		}
		public void Andar()
		{
			Console.WriteLine("Caminar");
		}
		public void Comer()
		{
			Console.WriteLine("Comer");
		}
	}
}
