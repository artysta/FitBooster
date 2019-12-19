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

        // Returns name of product added to the diet.
        public string GetName()
        {
            return Product.Name;
        }

        // Returns description of product added to the diet.
        public string GetDescription()
        {
            return Product.Description;
        }

        // Returns measurement unit of product added to the diet.
        public string GetUnit()
        {
            return Product.Unit;
        }

        // Returns amount of calories contained in product added to the diet.
        public double GetCalories()
        {
            return Product.GetCaloriesPerAmount(Amount);
        }

        // Returns amount of fat contained in product added to the diet.
        public double GetFat()
        {
            return Product.GetCaloriesPerAmount(Amount);
        }

        // Returns amount of carbs contained in product added to the diet.
        public double GetCarbs()
        {
            return Product.GetCaloriesPerAmount(Amount);
        }

        // Returns amount of proteins contained in product added to the diet.
        public double GetProteins()
        {
            return Product.GetCaloriesPerAmount(Amount);
        }
    }
}
