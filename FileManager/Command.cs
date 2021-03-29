using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
	public abstract class Command
	{
		public abstract string Name { get; }

		public virtual bool CanHandle(string cmd)
		{

			return cmd == Name;
		}

		public abstract void Handle();
	}

	public class HelpCommand : Command
	{
		public override string Name
		{
			get { return "help"; } // скрывет окно менеджера и выводит хелп
		}

		public override void Handle()
		{
			throw new NotImplementedException();
		}
	}

	public class CreateCommand : Command
	{
		public override string Name
		{
			get { return "create"; } // создание файла или каталога (зависит от курсора)
		}

		public override void Handle()
		{
			throw new NotImplementedException();
		}
	}

	public class DelCommand : Command
	{
		public override string Name
		{
			get { return "del"; }// удаление файла или каталога (зависит от курсора)
		}

		public override void Handle()
		{
			throw new NotImplementedException();
		}
	}
	public class CopyCommand : Command
	{
		public override string Name
		{
			get { return "copy"; }// копирование файла или каталога (зависит от курсора)
		}

		public override void Handle()
		{
			throw new NotImplementedException();
		}
	}
	public class MoveCommand : Command
	{
		public override string Name
		{
			get { return "move"; }
		}

		public override void Handle()
		{
			throw new NotImplementedException(); // перемещение файла или каталога (зависит от курсора)
		}
	}


}
