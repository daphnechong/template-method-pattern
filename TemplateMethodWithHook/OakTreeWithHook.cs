using System;

namespace TemplateMethodWithHook
{
	public class OakTreeWithHook : PlantWithHook
	{
		private readonly Acorn _acorn = new Acorn();

		protected override void OnBeforeEstablishRoots()
		{
			Console.WriteLine("Oak tree.OnBeforeEstablishRoots");
			_acorn.Split();
		}

		protected override void EstablishRoots()
		{
			Console.WriteLine("Oak tree.EstablishRoots");
			
			_acorn.CreateRoots();
		}

		protected override void SproutLeaves()
		{
			Console.WriteLine("Oak tree.SproutLeaves");
		}

		protected override void Bloom()
		{
			Console.WriteLine("Oak Tree.Bloom - Yay!");
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