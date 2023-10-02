using System;

namespace Interfaces.Models
{
	public class MsSqlOperation :Test, ITestInterface, ISqlOperation //birden fazla interface den miras alınabilir.
	{
		public void Connection()
		{
			Console.WriteLine("MsSql İçin bağlantı sağlandı.");
		}

		public bool Insert(Products product)
		{
			return true;
		}
	}

	public class MysqlOperation : ISqlOperation
	{
		public void Connection()
		{
			Console.WriteLine("MySql bağlantısı sağlandı.");
		}

		public bool Insert(Products product)
		{
			return true;
		}
	}

	public interface ISqlOperation //interface lerden nesne üretilemez. Amaçları miras vermektir.
	{
		void Connection(); //İnterface lerin içine yazılan metotların erişim belirteçleri olmaz.
		bool Insert(Products product);
	}

	public interface ITestInterface : ISqlOperation //interface ler birbirinden miras alabilirler.
	{

	}

	public class Test
	{

	}



}
