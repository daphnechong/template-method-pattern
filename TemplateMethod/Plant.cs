using System;

namespace TemplateMethod
{
	public abstract class Plant	
	{
		 public void Grow()
		 {
		 	AbsorbWater();
		 	EstablishRoots();
		 	SproutLeaves();
		 	Bloom();
		 }

		private void AbsorbWater()
		{
			Console.WriteLine("Plant - absorb some water");
		}

		protected abstract void EstablishRoots();
		
		protected abstract void SproutLeaves();

		protected abstract void Bloom();
	}
}