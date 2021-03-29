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
			
	/*		DriveInfo startDriveLeft = GetDrives()[0];
			DriveInfo startDriveRight = GetDrives()[1];
			var rootLeft = GetRootDir(startDriveLeft);
			var rootRight = GetRootDir(startDriveRight);*/
			List<Command> commands = new List<Command>();
			commands.Add(new HelpCommand());
			commands.Add(new CreateCommand());
			commands.Add(new DelCommand());
			commands.Add(new CopyCommand());
			commands.Add(new MoveCommand());





			Console.ReadKey();

		}

		static void ShowData((DirectoryInfo[] dirs, FileInfo[] files) leftSide, (DirectoryInfo[] dirs, FileInfo[] files) rightSide)
		{ 
			
		
		}




		static void WriteColor(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.Write(txt);
			Console.ResetColor();
		}
	}






}
