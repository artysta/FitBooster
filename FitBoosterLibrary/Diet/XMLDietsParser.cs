using System.Xml.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Globalization;

namespace FitBoosterLibrary
{
    // Class that helps to save (or load) products to XML file.
    public class XMLDietsParser : IDietsProvider
    {
        private readonly string path = $@"{Directory.GetCurrentDirectory()}\Diets.xml";
        public void AddDiet(Diet diet)
        {
            bool fileExists = File.Exists(path);

            // Create file if it does not exists.
            if (!fileExists)
            {
                var xmlTextWriter = new XmlTextWriter(path, System.Text.Encoding.UTF8) { Formatting = Formatting.Indented };
                xmlTextWriter.WriteStartDocument();
                xmlTextWriter.WriteStartElement("Diets");
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteEndDocument();
                xmlTextWriter.Close();
            }

            XDocument doc = XDocument.Load(path);

            XElement newDiet = new XElement("Diet",
                new XElement("Name", diet.Name),
                new XElement("Description", diet.Description));

            XElement productsOfDiet = new XElement("DietProducts");

            List<DietProduct> array = diet.Products;

            for (int i = 0; i < array.Count; i++)
            {
                XElement dietProduct = new XElement("DietProduct");

                dietProduct.Add
                    (
                    new XElement("Amount", array[i].Amount),
                    new XElement("Name", array[i].Name),
                    new XElement("Description", array[i].Description),
                    new XElement("Unit", array[i].Unit),
                    new XElement("Weight", array[i].Weight),
                    new XElement("Calories", array[i].Calories),
                    new XElement("Fat", array[i].Fat),
                    new XElement("Carbs", array[i].Carbs),
                    new XElement("Proteins", array[i].Proteins)
                    );

                productsOfDiet.Add(dietProduct);
            }

            newDiet.Add(productsOfDiet);
            doc.Element("Diets").Add(newDiet);
            doc.Save(path);
        }

        public List<Diet> GetAllDiets()
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} does not exists");
                return null;
            }

            List<Diet> diets = new List<Diet>();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList elemList = doc.GetElementsByTagName("Diet");

            // Iterate diets (<Diet>).
            for (int i = 0; i < elemList.Count; i++)
            {
                Diet diet = new Diet();
                diet.Name = elemList[i].ChildNodes[0].InnerText;
                diet.Description = elemList[i].ChildNodes[1].InnerText;

                // Iterate products of diet (<DietProducts>).
                for (int k = 0; k < elemList[i].ChildNodes[2].ChildNodes.Count; k++)
                {
                    var elements = elemList[i].ChildNodes[2].ChildNodes[k].ChildNodes;

                    // Create product.
                    Product product = new Product();
                    product.Name = elements[1].InnerText;
                    product.Description = elements[2].InnerText;
                    product.Unit = elements[3].InnerText;
                    product.Weight = double.Parse(elements[4].InnerText, CultureInfo.InvariantCulture);
                    product.Calories = double.Parse(elements[5].InnerText, CultureInfo.InvariantCulture);
                    product.Fat = double.Parse(elements[6].InnerText, CultureInfo.InvariantCulture);
                    product.Carbs = double.Parse(elements[7].InnerText, CultureInfo.InvariantCulture);
                    product.Proteins = double.Parse(elements[8].InnerText, CultureInfo.InvariantCulture);

                    int amount = int.Parse(elements[0].InnerText);
                    
                    diet.AddProduct(new DietProduct(product, amount));
                }

                diets.Add(diet);

                Console.WriteLine(diet.ToString());

            }

            return diets;
        }

        // TODO
        public void RemoveDiet(Diet diet)
        {
            throw new NotImplementedException();
        }
    }
}
