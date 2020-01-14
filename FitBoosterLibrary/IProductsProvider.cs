using System.Collections.Generic;

namespace FitBoosterLibrary
{
	public interface IProductsProvider
	{
		// Add product.
		void AddProduct(Product product);
		// Remove product.
		void RemoveProduct(Product product);
		// Return list of all products.
		List<Product> GetAllProducts();
	}
}
