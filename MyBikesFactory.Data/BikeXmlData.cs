using MyBikesFactory.Business; // ---
using System.Xml.Serialization; // ---
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Data
{
    public static class BikeXmlData
    {
        // too load and save data
        private static string GetFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "bikes.xml"; 
        }

        public static List<Bike> Load()
        {
            // for non existing files
            string filePath = GetFilePath();
            if (!File.Exists(filePath))
                return new List<Bike>();

            // file exists ; Opens the file and gets the strings from there
            string fileContent = File.ReadAllText(filePath);
            if (fileContent == "")
                return new List<Bike>();

            // Already have something in the file
            using (var reader = new StringReader(fileContent))
            {
                var serializer = new XmlSerializer(typeof(List<Bike>));
                return (List<Bike>)serializer.Deserialize(reader)!;
            }
        }

        // Save operation
        public static void Save(List<Bike> list)
        {
            string filePath = GetFilePath();

            using (var writer = new StreamWriter(filePath))
            {
                var serializer = new XmlSerializer(typeof(List<Bike>));
                serializer.Serialize(writer, list);
            }
        }
    }
}
