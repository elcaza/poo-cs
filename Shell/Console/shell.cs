using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Console
{
	public static class shell
	{
		public static void Start()
		{
			List<string> historial = new List<string>();
			string[] parametros;
			string inputComand;
			string arg;
			bool running = true;

			// Entramos a documents
			Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

			// Current directory
			string path = Directory.GetCurrentDirectory();

			do
			{
				System.Console.Write(path + "> ");

				inputComand = System.Console.ReadLine();

				// Añadimos el comando al historial
				historial.Add(inputComand);

				// Split para inputComand
				parametros = inputComand.Split(" ");

				// Si es 1 la opción es "." en caso contrario es la posición [1]
				if (parametros.Length == 1)
				{
					arg = ".";
				}
				else
				{
					arg = parametros[1];
				}

				try
				{
					// Validamos el comando
					switch (parametros[0])
					{
						case "dir":
							ListDirectory(arg);
							break;
						case "cd":
							path = ChangeDirectory(arg);
							break;
						case "cls":
							CleanScreen(arg);
							break;
						case "touch":
							CreateFile(parametros[1]);
							break;
						case "move":
							MoveFile(parametros[1], parametros[2]);
							break;
						case "history":
							foreach (var cmd in historial)
							{
								System.Console.WriteLine(cmd);
							}
							break;
						case "exit":
							System.Console.WriteLine("Adiós");
							running = false;
							break;
						default:
							System.Console.WriteLine("Error, comandos validos: dir, cd, cls, touch, move, history, exit");
							break;
					}
				}
				catch
				{
					System.Console.WriteLine("Error, verifique su input");
				}
			} while (running);
		}

		public static void ListDirectory(string arg)
		{
			try
			{
				// Obtiene los archivos y directorios
				DirectoryInfo directorioActual = new DirectoryInfo(arg);
				foreach (var fileActual in directorioActual.GetFiles())
				{
					System.Console.WriteLine(fileActual.Name);
				}
				foreach (var fileActual in directorioActual.GetDirectories())
				{
					System.Console.WriteLine(fileActual.Name);
				}
			}
			catch
			{
				System.Console.WriteLine("Error: Ruta o permisos invalidos");
			}
		}

		public static void CleanScreen(string armento)
		{
			System.Console.Clear();
		}

		public static string ChangeDirectory(string arg)
		{
			try
			{
				// Cambia el directorio actual
				Environment.CurrentDirectory = (arg);
				return Directory.GetCurrentDirectory();
			}
			catch
			{
				System.Console.WriteLine("Error: Ruta o permisos invalidos");
				return Directory.GetCurrentDirectory();
			}
		}

		public static void CreateFile(string arg)
		{
			try
			{
				StreamWriter newFile;
				newFile = File.CreateText(arg);
			}
			catch
			{
				System.Console.WriteLine("Error: Ruta o permisos invalidos");
			}
		}
		public static void MoveFile(string arg, string arg2)
		{
			try
			{
				File.Move(arg, arg2);
			}
			catch
			{
				System.Console.WriteLine("Error: Ruta o permisos o archivos invalidos.");
			}
		}

	}


}
