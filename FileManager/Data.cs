using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FileManager
{
	class Data
	{
		private static DriveInfo startDrive = GetDrives()[0];
		private DirectoryInfo currentDir;

		public Data()

		{

		}

		public Data(DirectoryInfo currentDir)

		{
			this.currentDir = currentDir;
		}

		public DirectoryInfo CurrentDir 	{
				get { return currentDir; }
				set
			{
				if (!string.IsNullOrEmpty(Properties.Resources.startDir))
				{
					currentDir. = Properties.Resources.startDir;
				}
			}

}



		public static(DirectoryInfo[] dirs, FileInfo[] files) GetDirInfo(DirectoryInfo currentDir)
		{
			if (currentDir==null)
			{
				currentDir = startDrive.RootDirectory;
			}
			return (currentDir.GetDirectories(), currentDir.GetFiles());
		}
		private static DriveInfo[] GetDrives()
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			return drives;
		}
	}
}
