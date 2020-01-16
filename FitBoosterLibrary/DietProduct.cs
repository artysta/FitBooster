using System;

namespace FitBoosterLibrary
{
    public class DietProduct
    {
        // Product added to the diet.
        private Product _product;
        // The amount of product added to the diet.
        private int _amount;

        // Returns or sets product.
        public Product Product
        {
            get => _product;
            set
            {
                _product = value ?? throw new ArgumentNullException("product", "Product cannot be null.");
            }
        }

        // Returns or sets amount of product added to the diet.
        public int Amount
        {
            get => _amount;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("amount", "Amount parameter cannot be less than 0.");
                _amount = value;
            }
        }

        public DietProduct(Product product, int amount)
        {
            Product = product;
            Amount = amount;
        }

        // Returns or sets name of the product.
        public string Name
        {
            get => Product.Name;
        }

        // Returns or sets description of the product.
        public string Description
        {
            get => Product.Description;
        }

        // Returns or sets unit of measurement of one product package.
        public string Unit
        {
            get => Product.Unit;
        }

        // Returns or sets weight of one product package.
        public double Weight
        {
            get => Amount;
        }

        // Returns or sets amount of calories contained in one product package.
        public double Calories
        {
            get => Product.GetCaloriesPerAmount(Amount);
        }

        // Returns or sets amount of fat contained in one product package.
        public double Fat
        {
            get => Product.GetFatPerAmount(Amount);
        }

        // Returns or sets amount of carbohydrates contained in one product package.
        public double Carbs
        {
            get => Product.GetCarbsPerAmount(Amount);
        }

        // Returns or sets amount of proteins contained in one product package.
        public double Proteins
        {
            get => Product.GetProteinsPerAmount(Amount);
        }
    }
}