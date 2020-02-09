using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluacion
{
	class Alumno
	{
		public string Nombre { get; set; }
		public string apellidoPaterno { get; set; }
		public string apellidoMaterno { get; set; }
		public double[] Calificaciones { get; set; }
		public double Calificacion { get; set; }
		// Constructor
		public Alumno(string nombre, string apellidoPaterno, string apellidoMaterno, double[] calificaciones)
		{
			Nombre = nombre;
			apellidoPaterno = apellidoPaterno;
			apellidoMaterno = apellidoMaterno;
			Calificacion = calculadora.califica(calificaciones);
		}

		public override string ToString()
		{
			return string.Format("El alumno {0} {1} {2} tiene {3:#.##} como calificacion final", Nombre, apellidoPaterno, apellidoMaterno, Calificacion);
		}
	}
}
