using System;

namespace _13Carrito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tesla: \n");
            Tesla carro_tesla = new Tesla(800, 1.50) { Modelo = "Cybertruck" };
            Console.WriteLine(carro_tesla.ToString());
            carro_tesla.Estado();
            carro_tesla.Encender();
            carro_tesla.Estado();
            carro_tesla.Apagar();
            carro_tesla.Estado();


            Console.WriteLine("\nBMW: \n");
            BMW carro_bmw = new BMW(600, 1.40) { Modelo = "BMW Model 1" };
            Console.WriteLine(carro_bmw.ToString());
            carro_bmw.Estado();
            carro_bmw.Encender();
            carro_bmw.Estado();
            carro_bmw.Apagar();
            carro_bmw.Estado();

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
