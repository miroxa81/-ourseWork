using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;

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
			var sideData = (Data.GetDirInfo(leftSideCurrentDir));
			ShowData(sideData, 1);
			sideData = (Data.GetDirInfo(rightSideCurrentDir));
			ShowData(sideData, Console.WindowWidth / 2 + 1);
			Console.ReadKey();
		}

		static void ShowData((DirectoryInfo[] dirs, FileInfo[] files) SideData, int x)
		{
			int y = 1;
			for (int i = 0; i < SideData.dirs.Length; i++)
			{
				if (y >20 )
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




		static void WriteColor(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.Write(txt);
			Console.ResetColor();
		}
	}






}
