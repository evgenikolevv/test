using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static zadacha1.Offices;

namespace zadacha1
{
	class Program
	{
		static void Main(string[] args)
		{
			Office o1 = new Office();
			o1.Building = 120;
			o1.Room = 3308;
			o1.Size = 100;
			Office o2 = new Office();
			o2.Building = 120;
			o2.Room = 2247;
			o2.Size = 146;
			Console.WriteLine("o1 hash = {0}, o2 hash = {1}", o1.GetHashCode(), o2.GetHashCode());
			Console.WriteLine("o1 string = {0}, o2 string = {1}", o1.ToString(), o2.ToString());
			if (o1 == o2) Console.WriteLine("o1 is equal to o2");
			else Console.WriteLine("o1 is not equal to o2");

			OfficeUnit ou = (OfficeUnit)o1;
			Console.WriteLine("Office Building Number: {0}", ou.Building);
			Console.WriteLine("Office Room Number: {0}", ou.Room);
			Console.WriteLine("Office Unit Size: {0}", ou.Size);
			Console.ReadLine();
		}
	}
}
