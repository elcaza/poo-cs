using System;

namespace _08Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            AutitoChocador a1 = new AutitoChocador();
            AutitoChocador a2 = new AutitoChocador("Autito genérico", 123456789, 500234.99);
            AutitoChocador a3 = new AutitoChocador("Autito Volador ", 098765432, 200123.99);

            Console.WriteLine(a1.Marca);
            a1.Encender();
            a1.Acelerar();
            a1.Apagar();

            Console.WriteLine();

            Console.WriteLine(a2.Marca);
            a2.Encender();
            a2.Acelerar();
            a2.Apagar();

            Console.WriteLine();

            Console.WriteLine(a3.Marca);
            a3.Encender();
            a3.Acelerar();
            a3.Apagar();

            Console.WriteLine();

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
