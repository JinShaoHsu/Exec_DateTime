using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入您的租借日期: ");
			string input1 = Console.ReadLine();
			DateTime input2 = Convert.ToDateTime(input1);
			var today2 = input2.AddMonths(1);
			Console.WriteLine("您的歸還期限為" + today2);


		}
	}
}
