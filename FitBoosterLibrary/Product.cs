using System;

namespace FitBoosterLibrary
{
    public class Product
    {
        // Just name of product.
        private string _name;
        // Short description of product.
        private string _description;
        // Unit of measurement (grams or mililiters).
        private string _unit;
        // Weight (in grams) or capacity (in mililiters) of one product package.
        private double _weight;
        // Amount of calories contained in one package of product.
        private double _calories;
        // Amount of fat (in grams) contained in one package of product.
        private double _fat;
        // Amount of carbohydrates (in grams) contained in one package of product.
        private double _carbs;
        // Amount of proteins (in grams) contained in one package of product.
        private double _proteins;

        public Product(string name, string description, MeasurementUnits unit, double weight, double calories, double fat, double carbs, double proteins)
        {
            Name = name;
            Description = description;
            Unit = unit.ToString();
            Weight = weight;
            Calories = calories;
            Fat = fat;
            Carbs = carbs;
            Proteins = proteins;
        }

        // Returns or sets name of the product.
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        // Returns or sets description of the product.
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
            }
        }

        // Returns or sets unit of measurement of one product package.
        public string Unit
        {
            get => _unit;
            set
            {
                if (value.Equals(MeasurementUnits.Grams.ToString()))
                {
                    _unit = "g";
                }
                else
                {
                    _unit = "ml";
                }
            }
        }

        // Returns or sets weight of one product package.
        public double Weight
        {
            get => _weight;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("weight", "Weight of product cannot be less than 0.");
                _weight = value;
            }
        }

        // Returns or sets amount of calories contained in one product package.
        public double Calories
        {
            get => _calories;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("calories", "Amount of calories cannot be less than 0.");
                _calories = value;
            }
        }

        // Returns or sets amount of fat contained in one product package.
        public double Fat
        {
            get => _fat;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("fat", "Amount of fat cannot be less than 0.");
                _fat = value;
            }
        }

        // Returns or sets amount of carbohydrates contained in one product package.
        public double Carbs
        {
            get => _carbs;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("carbs", "Amount of carbohydrates cannot be less than 0.");
                _carbs = value;
            }
        }

        // Returns or sets amount of proteins contained in one product package.
        public double Proteins
        {
            get => _proteins;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("proteins", "Amount of proteins cannot be less than 0.");
                _proteins = value;
            }
        }

        // Returns amount of calories in X (amount param) grams or mililiters of product.
        public double GetCaloriesPerAmount(int amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException("amount", "Amount parameter cannot be less than 0.");
            return Math.Round(amount * (Calories / Weight), 2);
        }

        // Returns amount of fat in X (amount param) grams or mililiters of product.
        public double GetFatPerAmount(int amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException("amount", "Amount parameter cannot be less than 0.");
            return Math.Round(amount * (Fat / Weight), 2);
        }

        // Returns amount of carbohydrates in X (amount param) grams or mililiters of product.
        public double GetCarbsPerAmount(int amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException("amount", "Amount parameter cannot be less than 0.");
            return Math.Round(amount * (Carbs / Weight), 2);
        }

        // Returns amount of proteins in X (amount param) grams or mililiters of product.
        public double GetProteinsPerAmount(int amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException("amount", "Amount parameter cannot be less than 0.");
            return Math.Round(amount * (Proteins / Weight), 2);
        }

        // Returns text information about X (amount param) grams or mililiters of product.
        public string GetProductAmountInfo(int amount) =>
            $"{amount} {Unit} of {Name} " +
            $"contains {GetProteinsPerAmount(amount)} g of proteins, " +
            $"{GetCarbsPerAmount(amount)} g of carbohydrates, " +
            $"{GetFatPerAmount(amount)} g of fat and {GetCaloriesPerAmount(amount)} calories.";

        // Returns text information about package of product.
        public string GetProductPackageInfo() =>
            $"One package ({Weight} {Unit}) of {Name} " +
            $"contains {Proteins} g of proteins, " +
            $"{Carbs} g of carbohydrates, " +
            $"{Fat} g of fat and {Calories} calories.";

        public override string ToString() =>
            $"[{nameof(Name)}] = {Name}, " +
            $"[{nameof(Description)}] = {Description}, " +
            $"[{nameof(Unit)}] = {Unit}, " +
            $"[{nameof(Weight)}] = {Weight}, " +
            $"[{nameof(Calories)}] = {Calories}, " +
            $"[{nameof(Fat)}] = {Fat}, " +
            $"[{nameof(Carbs)}] = {Carbs}, " +
            $"[{nameof(Proteins)}] = {Proteins}.";
    }
}
