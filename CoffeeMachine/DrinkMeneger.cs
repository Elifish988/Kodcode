using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CoffeeMachine
{
    internal class DrinkMeneger
    {
        private XmlDocument _document;
        
        public DrinkMeneger(XmlDocument doc)
        {
            _document = doc;
        }

        //יצירת רשימה בתוך רשימה של ליסטים
        public List<List<string>> GetDrinksData()
        {
            // הכרזה על הרשימה הסופית
            List<List<string>> AllDrinks = new List<List<string>>();
            //קריאת כל הליסטים בליסט הראשון
            XmlNodeList drinksNode = _document.SelectNodes("/drinks/drink");

            if (drinksNode != null) 
            {
                //כניסה לליסטים פנימים
                foreach (XmlNode drink in drinksNode)
                {
                    //הכרזה על הליסט הפנימי
                    List<string> drinkList = new List<string>();
                    if (drink.ChildNodes != null)
                    {
                        foreach(XmlNode drinkNode in drink.ChildNodes)
                        {
                            //הכנסה לליסט פנימי
                            drinkList.Add(drinkNode.InnerText);
                        }
                      //  הכנסה לליסט חיצוני
                        AllDrinks.Add(drinkList);
                    }

                }
            }
            return AllDrinks;
        }

        private XmlNode GetRoot()
        {
            // קבלת השורש
            return _document.GetElementsByTagName("drinks")[0];
        }

        public void AddDrink( List<string> drinks)
        {
            // יצירת משקה חדש
            XmlElement newDrink = _document.CreateElement("drink");
            List<string> tagName = new List<string>() { "name", "cacao", "milk",   "Coffee", "soger", "price" };
            for(int i = 0; i < tagName.Count; i++)
            {
                XmlElement child = _document.CreateElement(tagName[i]);
                child.InnerText = drinks[i];
                newDrink.AppendChild(child);
            }
            GetRoot().AppendChild(newDrink);

        }

        public void Save()
        {
            MainProject.save(_document);
        }

        public XmlNode GetDrinkByName(string name)
        {
 
            //XmlNodeList drinkList = _document.GetElementsByTagName("name");
            //if(drinkList == null)  return null;
            //foreach(XmlNode drink in drinkList)
            //{
            //if(drink.InnerText == name)
            //{
            //list = GetAllData(drink.ParentNode);
            //break;
            //}
            //}
            // חיפוש של נוד על פי "האם יש לן ילד שהינר שלו הוא שווה לניים
            XmlNode drink = _document.SelectSingleNode($"/drinks/drink[name = '{name}']");

            return drink;
            
        }

        private List<string> GetAllData(XmlNode drink)
        {
            List<string> list = new List<string>();
            foreach (XmlNode child in drink.ChildNodes)
            {
                list.Add(child.InnerText);
            }

            return list;

        }

        public void UpdateDrink(List<string> drinks)
        {
            //XmlNodeList drinkList = _document.GetElementsByTagName("name");
            //if (drinkList == null) return ;
            //foreach (XmlNode drink in drinkList)
            //{
            //    if(drink.InnerText == drinks[0])
            //    {
            //        int i = 0;
            //        foreach(XmlNode child in drink.ParentNode)
            //        {
            //            child.InnerText = drinks[i++];
            //        }
            //    }
            //}

            XmlNode drink = _document.SelectSingleNode($"/drinks/drink[name = '{drinks[0]}']");
                    int i = 0;
                    foreach(XmlNode child in drink.ChildNodes)
                    {
                        child.InnerText = drinks[i++];
                    }
        }

        public void delDrink(string name)
        {
            XmlNode drink = _document.SelectSingleNode($"drinks/drink[name = '{name}' ]");
            drink.ParentNode.RemoveChild(drink);

        }

    }

    
}
