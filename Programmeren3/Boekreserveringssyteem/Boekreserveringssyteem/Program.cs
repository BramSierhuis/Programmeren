using System;
using DAL;
using Model;

namespace ConsoleForSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        void Start()
        {
            CustomerDAO customerDAO = new CustomerDAO();
            BookDAO bookDAO = new BookDAO();
            ReservationDAO reservationDAO = new ReservationDAO();

            foreach (Customer c in customerDAO.GetAll())
                Console.WriteLine(c);

            Console.WriteLine();
            
            Customer customer = customerDAO.GetById(2);
            if(customer != null)
                Console.WriteLine(customer);
            else
                Console.WriteLine("Customer not found");

            Console.WriteLine();
            Console.WriteLine();

            foreach (Book b in bookDAO.GetAll())
                Console.WriteLine(b);

            Console.WriteLine();

            Book book = bookDAO.GetById(2);
            if(book != null)
                Console.WriteLine(book);
            else
                Console.WriteLine("Book not found");

            Console.WriteLine();
            Console.WriteLine();

            foreach (Reservation r in reservationDAO.GetAll())
                Console.WriteLine(r);

            Console.WriteLine();

            foreach (Reservation r in reservationDAO.GetAllForCustomer(customer))
                Console.WriteLine(r);

            Console.WriteLine();

            foreach (Reservation r in reservationDAO.GetAllForBook(book))
                Console.WriteLine(r);
        }
    }
}
