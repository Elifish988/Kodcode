using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Rabanut_IDF
{
    internal class mainRabanut
    {
        public mainRabanut() { }
        private static string _pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\Rabanut.xml");


        //מחבר לאקסמל
        public static XmlDocument Main()
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
                XmlNode foodsNode = xmlDoc.CreateElement("Queries");
                xmlDoc.AppendChild(foodsNode);
            }
            
            xmlDoc.Save(_pathString);
            return xmlDoc;

        }

        public static void save(XmlDocument xmlDocument)
        {
            xmlDocument.Save(_pathString);
        }


    }
}
