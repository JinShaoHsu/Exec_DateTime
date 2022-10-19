using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//根據日期,傳回今天是本月的上旬中旬或下旬
		
			Console.WriteLine("請輸入日期: ");
			string input = Console.ReadLine();
			DateTime today = Convert.ToDateTime(input);
			var today2 = Convert.ToInt32(today.Day);
			if (today2 >= 1 && today2 <= 10)
			{
				Console.WriteLine("今天是本月的上旬");
				return;
			}
			else if (today2 >= 11 && today2 <= 20)
			{
				Console.WriteLine("今天是本月的中旬");
				return;
			}
			else
			{
				Console.WriteLine("今天是本月的下旬");
			}
		}
	}
}
