using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluacion
{
	public static class calculadora
	{
		// Genera la calificacion de los alumnos
		public static double califica(double[] calificaciones)
		{
			double c_final = 0;

			c_final += calificaciones[0] * 0.6;
			c_final += calificaciones[1] * 10 / 5 * 0.4;
			if (calificaciones[2] > 5)
			{
				if (c_final < 10)
				{
					if ((c_final + (calificaciones[2] * 0.08)) > 10)
						c_final = 10.0;
					else
						c_final += (calificaciones[2] * 0.08);
				}
				else
					return c_final;
			}
			return c_final;
		}
	}
}
