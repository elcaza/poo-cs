using System;

namespace _09Math
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double longitudLado;
            string opcion = " ";
            
            Console.WriteLine("Circulo:");
            Console.Write("Ingrese el radio del cículo: ");
            try
            {
                radio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Círculo:");
                Circulo c1 = new Circulo(radio);
                c1.DatosCirculo();
            }
            catch
            { 
                Console.WriteLine("Dato no valido"); 
            }
                
            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();


        }
    }
}
