using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
	/*
	 * 5. Se debe simular una agenda telefónica. 
	 * Cuando inicie el programa se debe desplegar un menú con las opciones: 
	 * Agregar contacto 
	 * Eliminar contacto 
	 * Mostrar contacto 
	 * Salir 
	 * 
	 * Los contactos van a ser almacenados en un diccionario 
	 * (investiguen la colección Dictionary) en donde las llaves son los nombres de los contactos y sus valores van a ser los teléfonos. 
	 * Hacer pruebas en en el método Main.
	 */
	public static class Agenda
	{
		public static void Start()
		{
            string nombre;
            string numero;
            int opcion;
            Console.WriteLine("Agenda:");
            Dictionary<string, string> agenda = new Dictionary<string, string>();

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese una opción\nAgregar contacto (1)\nEliminar contacto (2)\nMostrar contacto (3)\nSalir (4)");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del contacto a añadir");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el número telefónico a añadir");
                        numero = Console.ReadLine();
                        agenda[nombre] = numero;
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el nombre del contacto a eliminar");
                        nombre = Console.ReadLine();
                        agenda.Remove(nombre);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el nombre del contacto a mostrar");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Nombre: {0} \nTeléfono: {1}", nombre, agenda[nombre]);
                        break;
                    default:
                        break;
                }
            } while (opcion != 4);
        }
	}
}
