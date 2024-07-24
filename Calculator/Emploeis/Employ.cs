using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empluys
{
    public class Employ
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string LastName { set; get; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public int Code { set; get; }
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }
        public string Status { set; get; }
        public string IsMale { set; get; }
        public string City { set; get; }
        public string Street { set; get; }
        public string Number { set; get; }
        public string Mobile { set; get; }
        public string Phone { set; get; }

        public Employ() { }
        public Employ(int id, string firstName, DateTime dateOfBirth, string lastName, string status, string isMale, string city, string street, string number, string mobile, string phone, int code)
        {
            Id = id;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            LastName = lastName;
            Status = status;
            IsMale = isMale;
            City = city;
            Street = street;
            Number = number;
            Mobile = mobile;
            Phone = phone;
            Code = code;
        }
    }
}
