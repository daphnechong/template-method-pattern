using System;
using System.Collections.Generic;

namespace TemplateMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			var plants = new List<Plant>
			{
			    new Daffodil(),
			    new OakTree()
			};

			
			foreach(var plant in plants)
			{
				plant.Grow();
				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}
