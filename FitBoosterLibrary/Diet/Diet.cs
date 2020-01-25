using System.Collections.Generic;
using System.Text;

namespace FitBoosterLibrary
{
    public class Diet
    {
        // Name of diet.
        private string _name;
        // Description of diet.
        private string _description;
        // List of products.
        private List<DietProduct> _products = new List<DietProduct>();

        // Returns or sets name of diet;
        public string Name { get => _name; set { _name = value; } }
        // Returns or sets description of diet;
        public string Description { get => _description; set { _description = value; } }

        public double TotalCalories { get => GetTotalCalories(); }
        public double TotalFat { get => GetTotalFat(); }
        public double TotalCarbs { get => GetTotalCarbs(); }
        public double TotalProteins { get => GetTotalProteins(); }


        // Returns or sets list of products.
        public List<DietProduct> Products { get => _products; set { _products = value; } }

        public Diet() { }

        public Diet(string name, string description)
        {
            Name = name;
            Description = description;
        }

        // Adds product to the list.
        public void AddProduct(DietProduct product)
        {
            Products.Add(product);
        }

        // Removes product from the list.
        public void RemoveProduct(DietProduct product)
        {
            Products.Remove(product);
        }

        // Returns amount of total calories of diet.
        public double GetTotalCalories()
        {
            double total = 0;

            foreach (DietProduct p in Products)
                total += p.Calories;

            return total;
        }

        // Returns amount of total fat of diet.
        public double GetTotalFat()
        {
            double total = 0;

            foreach (DietProduct p in Products)
                total += p.Fat;

            return total;
        }

        // Returns amount of total carbs of diet.
        public double GetTotalCarbs()
        {
            double total = 0;

            foreach (DietProduct p in Products)
                total += p.Carbs;

            return total;
        }

        // Returns amount of total proteins of diet.
        public double GetTotalProteins()
        {
            double total = 0;

            foreach (DietProduct p in Products)
                total += p.Proteins;

            return total;
        }

        // Returns info about diet.
        public string GetDietInfo()
        {
            if (Products.Count == 0) return "There are no products in diet.";

            StringBuilder sb = new StringBuilder();
            sb.Append($"Diet \"{Name}\" consists of products such as ");

            for (int i = 0; i < Products.Count; i++)
            {
                sb.Append($"{Products[i].Name} ({Products[i].Amount} {Products[i].Unit})");
                if (i == Products.Count - 1)
                {
                    sb.Append($". Sum of calories is {GetTotalCalories()}.");
                    break;
                }
                sb.Append(", ");
            }

            return sb.ToString();
        }
    }
}