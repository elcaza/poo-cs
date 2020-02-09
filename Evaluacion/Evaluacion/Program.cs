using System;
using System.Collections;
using System.Collections.Generic;

namespace Evaluacion
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Ingrese el número de alumnos a evaluar: ");

            int size_arr = Convert.ToInt32(Console.ReadLine());
            string nombre_alumno;
            string apellidoP_alumno;
            string apellidoM_alumno;

            double[] calificacion = new double[3];

            Alumno[] alumnos = new Alumno[size_arr];

            // Lee los datos de los alumnos, los valida y los almacena en un arreglo
            for (int i = 0; i < size_arr; i++)
            {
                Console.WriteLine("Nombre del alumno {0}:", i+1);
                nombre_alumno = Console.ReadLine();
                Console.WriteLine("Ingrese: Apellido paterno del alumno {0}:", i+1);
                apellidoP_alumno = Console.ReadLine();
                Console.WriteLine("Ingrese: Apellido materno del alumno {0}:", i+1);
                apellidoM_alumno = Console.ReadLine();
                Console.WriteLine("Ingrese la calificación del proyecto:");
               
                calificacion[0] = Convert.ToDouble(Console.ReadLine());
                if (calificacion[0] < 0 || calificacion[0] > 10)
                {
                    do
                    {
                        Console.WriteLine("La calificacion debe ser establecida del 5 al 10");
                        calificacion[0] = Convert.ToDouble(Console.ReadLine());
                    } while (calificacion[0] < 10 || calificacion[0] > 0);

                }
                Console.WriteLine("Ingrese el número de tareas entregadas por el alumno {0}:", i);
                calificacion[1] = Convert.ToDouble(Console.ReadLine());
                if (calificacion[1] < 0 || calificacion[1] > 5)
                {
                    do
                    {
                        Console.WriteLine("Las tareas están en un rango de 0 a 5 >:v");
                        calificacion[1] = Convert.ToDouble(Console.ReadLine());
                    } while (calificacion[1] > 5 || calificacion[1] < 0);

                }
                Console.WriteLine("Ingrese el número de participaciones hechas por el alumno {0}:", i);
                calificacion[2] = Convert.ToDouble(Console.ReadLine());
                if (calificacion[2] < 0)
                {
                    do
                    {
                        Console.WriteLine("Ingrese el número de participaciones hechas por el alumno {0}:");
                        calificacion[2] = Convert.ToDouble(Console.ReadLine());
                    } while (calificacion[2] < 0);
                }
                alumnos[i] = new Alumno(nombre_alumno, apellidoP_alumno, apellidoM_alumno, calificacion);
            }

            foreach (Alumno alum in alumnos)
            {
                Console.WriteLine(alum.ToString());
            }
            Console.ReadKey();

        }
	}
}
