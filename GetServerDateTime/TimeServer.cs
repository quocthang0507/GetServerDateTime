using System;
using System.IO;
using System.Net.Sockets;

namespace GetServerDateTime
{
	public class TimeServer
	{
		public string[] Servers = { "132.163.96.1", "132.163.96.2", "129.6.15.28", "129.6.15.29" };

		public TimeServer()
		{

		}

		public TimeServer(string[] servers)
		{
			this.Servers = servers;
		}

		public DateTime GetServerTime()
		{
			foreach (var server in Servers)
			{
				DateTime result = ConnectServer(server);
				if (result > DateTime.MinValue)
					return result;
			}
			return DateTime.MinValue;
		}

		public DateTime ConnectServer(string server)
		{
			string time;
			try
			{
				StreamReader reader = new StreamReader(new TcpClient(server, 13).GetStream());
				time = reader.ReadToEnd();
			}
			catch (Exception)
			{
				return DateTime.MinValue;
			}
			if (time.Substring(38, 9) != "UTC(NIST)" || time.Substring(30, 1) != "0")
				return DateTime.MinValue;
			int jd = int.Parse(time.Substring(1, 5));
			int yr = int.Parse(time.Substring(7, 2));
			int mo = int.Parse(time.Substring(10, 2));
			int dy = int.Parse(time.Substring(13, 2));
			int hr = int.Parse(time.Substring(16, 2));
			int mm = int.Parse(time.Substring(19, 2));
			int sc = int.Parse(time.Substring(22, 2));
			if (jd < 15020) return DateTime.MinValue; //trước năm 1900
			if (jd > 51544)
				yr += 2000;
			else
				yr += 1900;
			return new DateTime(yr, mo, dy, hr, mm, sc);
		}
	}
}
