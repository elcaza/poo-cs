using System;
using System.Collections.Generic;
using System.Text;

namespace FPalabra
{
	/*
	 * 3. Escribir un programa que pida al usuario una frase de texto e imprima la misma frase de texto, pero antes de cada vocal, agregue una f. 
	 * Ejemplo: "Mi nombre es Ana" "M nfombrfe fes fAnfa" 
	 */
	public static class FPalabra
	{
		public static void Start()
		{
            Console.WriteLine("Ingrese una frase");
            string frase = Console.ReadLine();

            char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            bool cambio = false;

            string nuevafrase = "";
            for (int i = 0; i < frase.Length; i++)
            {
                // Recorremos las vocales
                for (int j = 0; j < vocales.Length; j++)
                {
                    // Verificamos
                    if (frase[i].Equals(vocales[j]))
                    {
                        cambio = true;
                        nuevafrase += ("f" + frase[i]);
                        break;
                    }
                    else
                    {
                        cambio = false;
                    }
                }
                if (!cambio)
                    nuevafrase += frase[i];
            }
            Console.WriteLine(nuevafrase);
        }
	}
}
