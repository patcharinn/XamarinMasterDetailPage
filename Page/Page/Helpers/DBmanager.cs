using System;
using SQLite.Net;
using SQLite.Net.Interop;
using System.Collections.Generic;
using System.Linq;

namespace Page
{
	public class DBmanager
	{
		SQLiteConnection db;
		public DBmanager(string dbPath, ISQLitePlatform plateform)
		{
			db = new SQLiteConnection(plateform, dbPath);
			db.CreateTable<Customer>();
		}
		public List<Customer> GetCustomers()
		{
			return db.Table<Customer>().ToList();
		}
		public Customer GetCustomer(int id)
		{
			return db.Table<Customer>().
					 Where(c => c.id == id).Single();
		}
		//public Customer GetCustomer(string searchText)
		//{
		//	return db.Table<Customer>().
		//		     Where(c => c.NickName.Contains(searchText)).ToList();
		//}
		public bool InsertCustomer(Customer customers)
		{
			return db.Insert(customers) > 0;	 
		}
	}
}
