using System;

namespace TemplateMethodWithHook
{
	public abstract class PlantWithHook	
	{
		public void Grow()
		{
			AbsorbWater();
			OnBeforeEstablishRoots();
			EstablishRoots();
			SproutLeaves();

			if (IsAbleToBloom) 
			{
				Bloom();
			}
		}

		protected virtual bool IsAbleToBloom
		{
			get { return true; }
		}

		private void AbsorbWater()
		{
			Console.WriteLine("Plant.AbsorbWater");
		}

		protected virtual void OnBeforeEstablishRoots()
		{
		}

		protected abstract void EstablishRoots();
		
		protected abstract void SproutLeaves();

		protected abstract void Bloom();
	}
}