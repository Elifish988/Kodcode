using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Rabanut_IDF
{
    internal class RabnutMeneger
    {
        private XmlDocument _document;

        public RabnutMeneger(XmlDocument doc)
        {
            _document = doc;
        }

        public string Add(string cmbWekDay, string cmbMunsDay, string cmbMuns, string cmdYear)
        {
            XmlElement child = _document.CreateElement("Query");
            XmlElement Day = _document.CreateElement("Day");
            XmlElement DayMonth = _document.CreateElement("DayMonth");
            XmlElement Month = _document.CreateElement("Month");
            XmlElement Year = _document.CreateElement("Year");
            XmlElement Result = _document.CreateElement("Result");
            Day.InnerText = cmbWekDay ;
            DayMonth.InnerText = cmbMunsDay;
            Month.InnerText = cmbMuns;
            Year.InnerText = cmdYear;
            string result = Result1(cmbWekDay, cmbMunsDay, cmbMuns, cmdYear);
            Result.InnerText = result ;
            child.AppendChild(Day);
            child.AppendChild(DayMonth);
            child.AppendChild(Month);
            child.AppendChild(Year);
            child.AppendChild(Result);
            _document.DocumentElement.AppendChild(child);
            mainRabanut.save(_document);
            return result;

        }

        public string Result1(string cmbWekDay, string cmbMunsDay, string cmbMuns, string cmdYear)
        {
            string WekDay;
            string MunsDay;
            string Muns;
            string Year;
            string result;
            if (cmbWekDay == "ראשון") { WekDay = "אחד"; }
            else { WekDay = cmbWekDay; };

            
            

            List<string> dayMonthList = new List<string>()
  {
      "יום אחד לירח ", "שני ימים לירח ", "שלשה ימים לירח ", "ארבעה ימים לירח ",
      "חמשה ימים לירח ", "ששה ימים לירח ", "שבעה ימים לירח ", "שמנה ימים לירח ",
      "תשעה ימים לירח ", "עשרה ימים לירח ", "אחד עשר יום לירח ", "שנים עשר יום לירח ",
      "שלשה עשר יום לירח ", "ארבעה עשר יום לירח ", "חמשה עשר יום לירח ", "ששה עשר יום לירח ",
      "שבעה עשר יום לירח ", "שמנה עשר יום לירח ", "תשעה עשר יום לירח ", "עשרים יום לירח ",
      "אחד ועשרים יום לירח ", "שנים ועשרים יום לירח ", "שלשה ועשרים יום לירח ", "ארבעה ועשרים יום לירח ",
      "חמשה ועשרים יום לירח ", "ששה ועשרים יום לירח ","שבעה ועשרים יום לירח ","שמנה ועשרים יום לירח ",
      "תשעה ועשרים יום לירח ","יום שלושים ימים לירח ",
};
            MunsDay = dayMonthList[int.Parse(cmbMunsDay) - 1];
            Muns = cmbMuns;



            Year = cmdYear;

            result = ($"ב{WekDay} בשבת {MunsDay} {Muns} שנת {Year} לבריאת העולם.");


            return result;

        }




    }

    
}
