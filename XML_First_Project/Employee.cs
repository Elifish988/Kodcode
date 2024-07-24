using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XML_First_Project
{
    internal class Employee
    {
        public XmlDocument xmlDocument { get; set; }
        public Employee(XmlDocument xmlDocument)
        {
            this.xmlDocument = xmlDocument;
        }

        public void GetAllEmployees(XmlNodeList? xmlNodeList = null)
        {
            //יצירה ראשונית של רשימה
            if(xmlNodeList == null)
            {
                xmlNodeList = xmlDocument.SelectNodes("/Employees/Employee");
            }
            foreach(XmlNode children in xmlNodeList)
            {
                if(children.Attributes != null)
                {
                    foreach (XmlAttribute attribute in children.Attributes)
                    {
                        Console.WriteLine(attribute.Name + ": " + attribute.Value);
                    }
                }
                if(children.ChildNodes != null)
                {
                    GetAllEmployees(children.ChildNodes);
                }
            }
        }

        public void GetEmployeesById(string id )
        {
            XmlNode employee = xmlDocument.SelectSingleNode("/Employees/Employee[@id=" + id + "]");
            if (employee == null) return;
            if(employee.Attributes != null)
            {
                foreach(XmlNode attributes in employee.Attributes)
                {
                    Console.WriteLine(attributes.Name + ": " + attributes.Value);
                }
                if(employee.ChildNodes != null)
                {
                    GetAllEmployees(employee.ChildNodes);
                }
            }
        }
    }
}
