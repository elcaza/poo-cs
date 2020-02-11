using System;

namespace _06CuentaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
			CuentaBancaria c1 = new CuentaBancaria("Tim Tymoteo Thompson", 1532.50);
			CuentaBancaria c2 = new CuentaBancaria("Jefferson Gutierritos", 1200.45);
			c1.mostarInformacion();
			c2.depositar(500.30);
			c1.retirar(200.10);
			c1.retirar(100.50);
			c1.mostarInformacion();
			c2.mostarInformacion();
			Console.WriteLine("Presiones cualquier tecla para salir");
			Console.ReadKey();
		}
    }
}
