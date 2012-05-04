using System;
using System.Collections.Generic;

namespace TemplateMethodWithHook
{
	class Program
	{
		static void Main(string[] args)
		{
			var plants = new List<PlantWithHook>
			{
			    new DaffodilWithHook(),
			    new OakTreeWithHook()
			};


			foreach (var plant in plants)
			{
				plant.Grow();
				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}
