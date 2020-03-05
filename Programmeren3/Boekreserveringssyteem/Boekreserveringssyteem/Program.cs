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

            foreach (Customer c in customerDAO.GetAll())
                Console.WriteLine(c);

            Console.WriteLine();
            
            Customer customer = customerDAO.GetById(2);
            if(customer != null)
                Console.WriteLine(customer);
            else
                Console.WriteLine("Customer not found");
        }
    }
}
