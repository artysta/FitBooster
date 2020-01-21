using System.Collections.Generic;

namespace FitBoosterLibrary
{
	public interface IDietsProvider
	{
		// Add diet.
		void AddDiet(Diet diet);
		// Remove diet.
		void RemoveDiet(Diet diet);
		// Return list of all diets.
		List<Diet> GetAllDiets();
	}
}