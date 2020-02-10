using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    public static class Fibonacci
    {
        public static void Start()
        {
            int n1 = 0;
            int n2 = 1;
            int temp;
            int limite = 0;

            Console.WriteLine("Ingrese el numero de elementos a mostrar");
            try
            {
                limite = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Se debe ingresar solamente numeros enteros");
            }
            finally
            {
                Console.WriteLine("\n La serie de Fibonacci es: \n");
                Console.Write("0 ");
                for (int i = 0; i < limite; i++)
                {
                    temp = n1;
                    n1 = n2;
                    n2 = temp + n1;
                    Console.Write(n1 + " ");
                }
            }
        }
    }
}
