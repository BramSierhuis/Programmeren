using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Customer
    {
        private int id;

        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string LastName { get; set; }

        public Customer(int id, string firstName, string lastName, string emailAddress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            FullName = firstName + " " + lastName;
        }

        public override string ToString()
        {
            return Id + ". " + FullName + " (" + EmailAddress + ")";
        }
    }
}
