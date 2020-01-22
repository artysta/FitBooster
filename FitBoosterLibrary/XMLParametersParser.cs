using System.Xml.Linq;
using System.IO;
using System;
using System.Xml;
using System.Globalization;

namespace FitBoosterLibrary
{
    // Class that helps to save (or load) parameters to XML file.
    public class XMLParametersParser
    {
        private readonly string path = $@"{Directory.GetCurrentDirectory()}\Parameters.xml";
        public void AddParameter(Parameter parameter)
        {
            // Create file if it does not exist.
            if (!File.Exists(path))
            {
                var xmlTextWriter = new XmlTextWriter(path, System.Text.Encoding.UTF8) { Formatting = Formatting.Indented };
                xmlTextWriter.WriteStartDocument();
                xmlTextWriter.WriteStartElement("Parameters");
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteEndDocument();
                xmlTextWriter.Close();
            }

            DateTime date = DateTime.Now.Date;

            XDocument doc = XDocument.Load(path);

            XElement newProduct = new XElement("Parameter",
                new XElement("Weight", parameter.Weight),
                new XElement("BMI", parameter.Bmi),
                new XElement("TargetBMI", parameter.TargetBmi),
                new XElement("LastUpdated", date.ToString()));

            doc.Element("Parameters").Add(newProduct);
            doc.Save(path);
        }

        // Returns latest parameters.
        public Parameter GetLatestParameter()
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} does not exist");
                return null;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList elemList = doc.GetElementsByTagName("Parameter");

            Parameter parameter = new Parameter();

            var elem = elemList[elemList.Count - 1];

            parameter.Weight = double.Parse(elem.ChildNodes[0].InnerText, CultureInfo.InvariantCulture);
            parameter.Bmi = double.Parse(elem.ChildNodes[1].InnerText, CultureInfo.InvariantCulture);
            parameter.TargetBmi = double.Parse(elem.ChildNodes[2].InnerText, CultureInfo.InvariantCulture);
            parameter.LastUpdated = DateTime.Parse(elem.ChildNodes[3].InnerText);

            return parameter;
        }
    }
}
