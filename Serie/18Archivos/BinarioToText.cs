using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class ReadFromFile
{
	/*
	* Función para convertir un string a binario
	*/
	static public Byte[] GetBytesFromBinaryString(String binary)
	{
		var list = new List<Byte>();

		for (int i = 0; i < binary.Length; i += 8)
		{
			String t = binary.Substring(i, 8);
			list.Add(Convert.ToByte(t, 2));
		}

		return list.ToArray();
	}

	
	static void Main()
	{		
		Byte[] data = GetBytesFromBinaryString("01000010");
		string textbin = Encoding.ASCII.GetString(data);
		string inputFile = @".\binary.txt";
		string outputFile = @".\text.txt";

		// Leemos todas las líneas
		try {
			string[] lines = System.IO.File.ReadAllLines(inputFile);
			try {
				// Recorremos cada línea y por cada palabra que encontremos lo convertiremos a ASCII
				foreach (string line in lines)
				{
					// Console.WriteLine("\t" + line);
					// Console.WriteLine("\t" + line.Length);
					
					data = GetBytesFromBinaryString(line);
					textbin = Encoding.ASCII.GetString(data);
					
					// Console.WriteLine(textbin);

					using (System.IO.StreamWriter file = new System.IO.StreamWriter(outputFile, true))
					{
						if (line.Length == 0){
							file.Write("\n");	
						} 
						else 
						{
							file.Write(textbin + " ");
						}
					}
				}

				Console.WriteLine("Archivo creado en '.\\text.txt'");
			} catch {
				Console.WriteLine("Formato de entrada no válido, revise README.md");
			}
		}
		catch {
			Console.WriteLine("El de entrada no existe");
		}
		

		
		
		Console.WriteLine("Presione cualquier tecla para salir");
		System.Console.ReadKey();
	}
}