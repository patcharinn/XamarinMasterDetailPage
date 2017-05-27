using System;
using SQLite.Net.Attributes;
namespace Page
{
	public class Customer
	{
		[PrimaryKey,AutoIncrement]
		public int id { get; set; }

		public string FullName { get; set; }
		public string NickName { get; set; }
	}
}
