using System;

namespace ClapProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Clap.Start();
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
