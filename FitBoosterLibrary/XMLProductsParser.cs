using System.Xml.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.Xml;

namespace FitBoosterLibrary
{
    // Class that helps to save (or load) products to XML file.
	public class XMLProductsParser : IProductsProvider
	{
        private readonly string path = $@"{Directory.GetCurrentDirectory()}\Products.xml";
		public void AddProduct(Product product)
		{
            bool fileExists = File.Exists(path);

            if (fileExists)
            {
                XDocument doc = XDocument.Load(path);

                XElement newProduct = new XElement("Product",
                    new XElement("Name", product.Name),
                    new XElement("Description", product.Description),
                    new XElement("Unit", product.Unit),
                    new XElement("Weight", product.Weight.ToString()),
                    new XElement("Calories", product.Calories.ToString()),
                    new XElement("Fat", product.Fat.ToString()),
                    new XElement("Carbs", product.Carbs.ToString()),
                    new XElement("Proteins", product.Proteins.ToString()));

                doc.Element("Products").Add(newProduct);
                doc.Save(path);

            }
            else
            {
                var xmlTextWriter = new XmlTextWriter(path, System.Text.Encoding.UTF8) { Formatting = Formatting.Indented };

                xmlTextWriter.WriteStartDocument();

                xmlTextWriter.WriteStartElement("Products");
                xmlTextWriter.WriteStartElement("Product");
                xmlTextWriter.WriteElementString("Name", product.Name);
                xmlTextWriter.WriteElementString("Description", product.Description);
                xmlTextWriter.WriteElementString("Unit", product.Unit);
                xmlTextWriter.WriteElementString("Weight", product.Weight.ToString());
                xmlTextWriter.WriteElementString("Calories", product.Calories.ToString());
                xmlTextWriter.WriteElementString("Fat", product.Fat.ToString());
                xmlTextWriter.WriteElementString("Carbs", product.Carbs.ToString());
                xmlTextWriter.WriteElementString("Proteins", product.Proteins.ToString());

                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteEndElement();

                xmlTextWriter.WriteEndDocument();
                xmlTextWriter.Close();
            }
        }

		public List<Product> GetAllProducts()
		{
            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} does not exists");
                return null;
            }

            List<Product> products = new List<Product>();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            
            XmlNodeList elemList = doc.GetElementsByTagName("Product");
            for (int i = 0; i < elemList.Count; i++)
            {
                Product product = new Product();

                product.Name = elemList[i].ChildNodes[0].InnerText;
                product.Description = elemList[i].ChildNodes[1].InnerText;
                product.Unit = elemList[i].ChildNodes[2].InnerText;
                product.Weight = double.Parse(elemList[i].ChildNodes[3].InnerText);
                product.Calories = double.Parse(elemList[i].ChildNodes[4].InnerText);
                product.Fat = double.Parse(elemList[i].ChildNodes[5].InnerText);
                product.Carbs = double.Parse(elemList[i].ChildNodes[6].InnerText);
                product.Proteins = double.Parse(elemList[i].ChildNodes[7].InnerText);

                products.Add(product);
            }

            return products;
        }

        // TODO
		public void RemoveProduct(Product product)
		{
			throw new NotImplementedException();
		}
	}
}
