
// See https://aka.ms/new-console-template for more information

using System.Xml;
using XML_First_Project;

XmlDocument xmlDocument = XML_First_Project.XML_First_Project.Main();
Employee employee = new Employee(xmlDocument);
employee.GetAllEmployees();
employee.GetEmployeesById( "3");
