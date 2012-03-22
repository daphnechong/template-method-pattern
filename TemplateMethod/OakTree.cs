using System;

namespace TemplateMethod
{
	public class OakTree : Plant
	{
		private readonly Acorn _acorn = new Acorn();
		private Trunk _trunk = new Trunk();

		protected override void EstablishRoots()
		{
			Console.WriteLine("Oak tree - establishing roots");
			_acorn.Split();
			_acorn.CreateRoots();
		}

		protected override void SproutLeaves()
		{
			Console.WriteLine("Oak tree - sprouting some leaves.");
			_trunk.AddLeaf();
			_trunk.AddLeaf();
			_trunk.AddLeaf();
		}

		protected override void Bloom()
		{
			Console.WriteLine("Oak Tree - growing some acorns. Yay!");
			_trunk.GrowAcorns();
		}
	}

	public class Trunk
	{
		public void AddLeaf()
		{
		}

		public void GrowAcorns()
		{
		}
	}

	public class Acorn
	{
		public void Split()
		{
		}

		public void CreateRoots()
		{
		}
	}

}