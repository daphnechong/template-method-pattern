using System;
using System.Collections.Generic;

namespace TemplateMethod
{
	public class Daffodil : Plant
	{
		private readonly List<Leaf> _leaves = new List<Leaf>();

		protected override void EstablishRoots()
		{
			Console.WriteLine("Daffodil.EstablishRoots");
		}

		protected override void SproutLeaves()
		{
			Console.WriteLine("Daffodil.SproutLeaves");
			for (int i = 0; i < 5; i++)
			{
				_leaves.Add(new Leaf());
			}
		}

		protected override void Bloom()
		{
			Console.WriteLine("Daffodil.Bloom - yay!");
		}
	}

	public class Leaf
	{
	}
}