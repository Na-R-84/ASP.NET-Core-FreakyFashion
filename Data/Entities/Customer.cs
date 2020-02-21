using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion.Data.Entities
{
    public class Customer
    {
        public Customer( int id,string name, string lastName, string socialSecurityNumber, int phoneNumber, string mail, string address)
        {
            Id = id;
            Name = name;
            LastName= lastName;
            SocialSecurityNumber = socialSecurityNumber;
            PhoneNumber = phoneNumber;
            Mail = mail;
            Address = address;
        }

        public Customer(int id, string name, string lastName, string socialSecurityNumber, int phoneNumber, string mail, string address, Order order)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            PhoneNumber = phoneNumber;
            Mail = mail;
            Address = address;
            Order = order;
        }
        public int Id { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }

        public string SocialSecurityNumber { get; set; }

        public int PhoneNumber { get; set; }
        public Order Order { get; set; }


        public string Mail { get; set; }

        public string Address { get; set; }

    }
}
