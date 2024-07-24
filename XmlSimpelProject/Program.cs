// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Xml;

namespace XmlSimpelProject 
{

    public class Progrem
    {


        // שם של נתיב
        private static string _pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..") + "\\Foods.xml");
        

        public static XmlDocument Main(string[] args)
        { 
            XmlDocument xmlDoc;
            //קריאת קובץ
            if (File.Exists(_pathString))
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(_pathString);
            }
            //יצירת קובץ חדש עם נוד ראשון
            else
            {
                xmlDoc = new XmlDocument();
                //נוד ראשון משתמשים ב אקסמל נוד
                XmlNode foodsNode = xmlDoc.CreateElement("foods");
                xmlDoc.AppendChild(foodsNode);
            }
            

            if (File.Exists(_pathString))
            {
                //נוד שני והילך משתמשים באקסמל אלמנט
                XmlElement child = xmlDoc.CreateElement("food");
                XmlElement name = xmlDoc.CreateElement("name");
                XmlElement prise = xmlDoc.CreateElement("prise");
                name.InnerText = "לחם";
                prise.InnerText = "3.5";
                child.AppendChild(name);
                child.AppendChild(prise);
                //XmlNode foodsNode = xmlDoc.SelectSingleNode("foods");
                //if (foodsNode != null)
                //{
                //    foodsNode.AppendChild(child);
                //}
                xmlDoc.DocumentElement.AppendChild(child);
            }
            xmlDoc.Save(_pathString);
        }


    }
}

    