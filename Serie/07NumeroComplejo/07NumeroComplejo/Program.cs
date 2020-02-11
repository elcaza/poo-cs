using System;

namespace _07NumeroComplejo
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroComplejo n1 = new NumeroComplejo(4, -10);
            NumeroComplejo n2 = new NumeroComplejo(12, 12);
            NumeroComplejo n3;
            n1.imprimir();
            n2.imprimir();
            Console.WriteLine("La suma es:");
            n3 = n2.sumar(n1);
            n3.imprimir();
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
