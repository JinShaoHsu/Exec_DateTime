using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime LastDay = DateTime.Now.AddMonths(1).AddDays(-DateTime.Now.AddMonths(1).Day);
			string lastday1 = LastDay.ToString("yyyy/MM/dd");
			Console.WriteLine("本月最後一天為: " + lastday1);
		}
	}
}
