using System;
using System.IO;

namespace Page.iOS
{
	public interface PlatformHelpers:IPlatformHelpers
	{
		public string GetDbPath()
		{
			var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			path = Path.Combine(path,"..","Library","mydb.sqlite3");
			return path;
		}
		public string GetPlatform()
		{
			return new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
		}
	}
}
