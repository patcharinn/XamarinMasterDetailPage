using System;
using SQLite.Net.Interop;
namespace Page
{
	public interface IPlatformHelpers
	{
		string GetDbPath();
		ISQLitePlatform GetPlatform();
	}
}
