using System;
using System.Collections.Generic;
using System.Text;

namespace _14Interfaces
{
    public class Aves : Interface_Animal
	{
		public int Patas = 2;
		public int Alas = 2;
		public int Cola = 1;
		public string Nombre { get; private set; }
		public Aves(string NAve)
		{
			this.Nombre = NAve;
		}
		public void Andar()
		{
			Console.WriteLine("Volar");
		}
		public void Comer()
		{
			Console.WriteLine("Comer");
		}
	}
}
