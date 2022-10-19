using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入您DVD的租借日期: ");
			string input1 = Console.ReadLine();
			DateTime input2 = Convert.ToDateTime(input1);
			var today2 = input2.AddDays(3);
			Console.WriteLine(today2);


		}
	}
}
