using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
	class Data
	{
		private DirectoryInfo _currentDirectory;
		private DirectoryInfo _directories;
		private DriveInfo _drive;

		public DirectoryInfo Directories
		{
			get { return _directories; }
			private set { _currentDirectory.GetDirectories(); }
		}

		public DirectoryInfo CurrentDirectory
		{
			get { return _currentDirectory; }
			set { _currentDirectory = value; }
		}


	}
}
