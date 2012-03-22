using System;
using System.Collections.Generic;

namespace TemplateMethod
{
	public class Daffodil : Plant
	{
		private readonly Bulb _bulb = new Bulb();
		private readonly List<Leaf> _leaves = new List<Leaf>();

		protected override void EstablishRoots()
		{
			Console.WriteLine("Bulb - Creating Roots");
			_bulb.CreateRoots();
		}

		protected override void SproutLeaves()
		{
			Console.WriteLine("Bulb - sprouting some leaves");
			for (int i = 0; i < 5; i++)
			{
				var leaf = _bulb.CreateLeaf();
				_leaves.Add(leaf);
			}
		}

		protected override void Bloom()
		{
			Console.WriteLine("Bulb - blooming. yay!");
		}
	}

	public class Bulb
	{
		public void CreateRoots()
		{
		}

		public Leaf CreateLeaf()
		{
			return new Leaf();
		}
	}

	public class Leaf
	{
	}
}