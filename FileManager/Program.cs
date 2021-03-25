using System;
using System.Collections.Generic;
using System.IO;

namespace FileManager
{
	class Program
	{
		static void Main(string[] args)
		{

			DriveInfo startDriveLeft = GetDrives()[0];
			DriveInfo startDriveRight = GetDrives()[1];
			var rootLeft = GetRootDir(startDriveLeft);
			var rootRight = GetRootDir(startDriveRight);
			var leftSide = GetDirInfo(rootLeft);
			var rigthSide = GetDirInfo(rootRight);
			Console.ReadKey();

			var sideData = new Data();

			//sideData.CurrentDirectory = startDriveLeft
		}




		static DriveInfo[] GetDrives()
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			return drives;
		}

		static DirectoryInfo GetRootDir(DriveInfo Drive)
		{
			return Drive.RootDirectory;
		}
		static (DirectoryInfo[] dirs, FileInfo[] files) GetDirInfo(DirectoryInfo currentDirectory)
		{
			return (currentDirectory.GetDirectories(), currentDirectory.GetFiles());
		}
		static void WriteColor(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.Write(txt);
			Console.ResetColor();
		}
	}



}
