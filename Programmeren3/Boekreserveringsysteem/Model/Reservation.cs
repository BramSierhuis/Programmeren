using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Reservation
    {
        private int id;
        private Book book;
        private Customer customer;

        public Book Book { get; set; }
        public Customer Customer { get; set; }
        public int Id { get; set; }
        public DateTime ReservationDateTime { get; set; }

        public Reservation(int id, Customer customer, Book book)
        {
            Book = book;
            Customer = customer;
            Id = id;
            ReservationDateTime = DateTime.Today;
        }

        public override string ToString()
        {
            return "Getting reservation " + Id + " for " + Book + " by " + Customer;
        }
    }
}
