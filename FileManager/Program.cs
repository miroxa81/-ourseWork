using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using System.Runtime.InteropServices;


namespace FileManager
{
	class Program
	{

		static void Main(string[] args)
		{


			DirectoryInfo leftSideCurrentDir = new DirectoryInfo(Properties.Resources.leftStartDir);
			DirectoryInfo rightSideCurrentDir = new DirectoryInfo(Properties.Resources.rightStartDir);

			List<Command> commands = new List<Command>();
			commands.Add(new HelpCommand());
			commands.Add(new CreateCommand());
			commands.Add(new DelCommand());
			commands.Add(new CopyCommand());
			commands.Add(new MoveCommand());


			ConsoleKeyInfo cki;
			// Prevent example from ending if CTL+C is pressed.
			Console.TreatControlCAsInput = true;


			int xLeft = 5;
			int yLeft = 1;

			int xRight = Console.WindowWidth / 2 + 1;
			int yRight = 1;
			do
			{
				cki = Console.ReadKey();
				var sideData = (GetDirInfo(leftSideCurrentDir));
				ShowData(sideData, xLeft, yLeft); ;
				sideData = (GetDirInfo(rightSideCurrentDir));
				ShowData(sideData, xRight, yRight);

				switch (cki.Key)
				{
					case ConsoleKey.LeftArrow:
						{
							break;
						}
					case ConsoleKey.RightArrow:
						{
							break;
						}
					case ConsoleKey.UpArrow:
						{
							break;
						}
					case ConsoleKey.DownArrow:
						{
							break;
						}


				}



			} while (cki.Key != ConsoleKey.Escape);




		}

		public void Cursor(int x, int y, int lenght)
		{
			var block = (char)2591;

			for (int i = x; i < lenght; i++)
			{
				Console.SetCursorPosition(i, y);
				Console.Write(block);
			}
		
		}

		static void ShowData((DirectoryInfo[] dirs, FileInfo[] files) SideData, int x, int y)
		{
			
			for (int i = 0; i < SideData.dirs.Length; i++)
			{
				if (y > 20)
				{
					break;
				}
				Console.SetCursorPosition(x, y);
				WriteColor(SideData.dirs[i].Name, ConsoleColor.Gray);
				y++;

			}
			for (int i = 0; i < SideData.files.Length; i++)
			{
				if (y > 20)
				{
					break;
				}
				Console.SetCursorPosition(x, y);
				WriteColor(SideData.files[i].Name, ConsoleColor.DarkGray);
				y++;

			}
		}


		static (DirectoryInfo[] dirs, FileInfo[] files) GetDirInfo(DirectoryInfo currentDir)
		{
			return (currentDir.GetDirectories(), currentDir.GetFiles());
		}


		static void WriteColor(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.Write(txt);
			Console.ResetColor();
		}
	}






}
