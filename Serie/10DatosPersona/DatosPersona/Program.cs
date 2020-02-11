using System;

namespace DatosPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int year;
            int altura;
            int peso;

            Console.WriteLine("Conversion de datos de una persona al sistema inglés.");
            Console.WriteLine("Ingresa los datos de la persona:");
            Console.WriteLine("Nombre : ");
            nombre = Console.ReadLine();


            do
            {
                try
                {
                    Console.WriteLine("Año de nacimiento (YYYY) : ");
                    year = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ingrese un dato válido");
                }
            } while (true);


            do
            {
                try
                {
                    Console.WriteLine("Altura (cm): ");
                    altura = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ingrese un dato válido");
                }
            } while (true);

            do
            {
                try
                {
                    Console.WriteLine("Peso (kg): ");
                    peso = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ingrese un dato válido");
                }
            } while (true);

            Persona nuevo = new Persona(nombre, year, altura, peso);


            nuevo.calcularEdad(year);
            nuevo.cmToft(altura);
            nuevo.kgTolb(peso);

            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
