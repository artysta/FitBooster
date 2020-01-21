using System.Collections.Generic;

namespace FitBoosterLibrary
{
	// Class that provides sample products for the application.
	public class SampleDietsProvider : IDietsProvider
	{
		private static List<Diet> _diets = new List<Diet>();

		public void AddDiet(Diet diet) => _diets.Add(diet);
		public void RemoveDiet(Diet diet) => _diets.Remove(diet);
		public List<Diet> GetAllDiets() => _diets;
	}
}
