using System.Collections.Generic;

namespace FitBoosterLibrary
{
	// Class that provides sample products for the application.
	public class SampleProductsProvider : IProductsProvider
	{
		private static List<Product> _products = new List<Product>()
		{
			{ new Product("Cottage cheese", "Fresh and tasty", "g", 200, 194, 10, 4, 22) },
			{ new Product("Apple", "Fresh and sweet fruit", "g", 180, 90, 0.7, 18.2, 3.6) },
			{ new Product("Egg", "Ingredient of many dishes", "g", 56, 78, 5.4, 0.3, 7) }
		};

		public void AddProduct(Product product) => _products.Add(product);
		public void RemoveProduct(Product product) => _products.Remove(product);
		public List<Product> GetAllProducts() => _products;
	}
}
