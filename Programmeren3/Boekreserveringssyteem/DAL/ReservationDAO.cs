using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class ReservationDAO
    {
        private SqlConnection dbConnection;

        public ReservationDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["Boekreserveringsysteem"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
        
        public List<Reservation> GetAll()
        {
            dbConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT Reservations.Id, CustomerId, BookId, Title, Author, FirstName, LastName, EmailAddress FROM Reservations JOIN Books ON BookId = Books.Id JOIN Customers ON CustomerId = Customers.Id", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Reservation> reservations = new List<Reservation>();

            while (reader.Read())
            {
                Reservation r = ReadReservation(reader);
                reservations.Add(r);
            }

            reader.Close();
            dbConnection.Close();

            return reservations;
        }

        public List<Reservation> GetAllForCustomer(Customer customer)
        {
            dbConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT Reservations.Id, CustomerId, BookId, Title, Author, FirstName, LastName, EmailAddress FROM Reservations JOIN Books ON BookId = Books.Id JOIN Customers ON CustomerId = Customers.Id WHERE CustomerId = @Id", dbConnection);
            cmd.Parameters.AddWithValue("@Id", customer.Id);

            SqlDataReader reader = cmd.ExecuteReader();
            List<Reservation> reservations = new List<Reservation>();

            while (reader.Read())
            {
                Reservation r = ReadReservation(reader);
                reservations.Add(r);
            }

            reader.Close();
            dbConnection.Close();

            return reservations;
        }

        public List<Reservation> GetAllForBook(Book book)
        {
            dbConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT Reservations.Id, CustomerId, BookId, Title, Author, FirstName, LastName, EmailAddress FROM Reservations JOIN Books ON BookId = Books.Id JOIN Customers ON CustomerId = Customers.Id WHERE BookId = @Id", dbConnection);
            cmd.Parameters.AddWithValue("@Id", book.Id);

            SqlDataReader reader = cmd.ExecuteReader();
            List<Reservation> reservations = new List<Reservation>();

            while (reader.Read())
            {
                Reservation r = ReadReservation(reader);
                reservations.Add(r);
            }

            reader.Close();
            dbConnection.Close();

            return reservations;
        }

        private Customer ReadCustomer(SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string firstName = (string)reader["FirstName"];
            string lastName = (string)reader["LastName"];
            string emailAddress = (string)reader["EmailAddress"];

            return new Customer(id, firstName, lastName, emailAddress);
        }

        private Book ReadBook(SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string author = (string)reader["Author"];
            string title = (string)reader["Title"];

            return new Book(id, title, author);
        }

        private Reservation ReadReservation(SqlDataReader reader)
        {
            int id = (int)reader["Id"];
            int customerId = (int)reader["CustomerId"];
            string firstName = (string)reader["FirstName"];
            string lastName = (string)reader["LastName"];
            string emailAddress = (string)reader["EmailAddress"];
            int bookId = (int)reader["BookId"];
            string author = (string)reader["Author"];
            string title = (string)reader["Title"];

            Customer c = new Customer(customerId, firstName, lastName, emailAddress);
            Book b = new Book(bookId, title, author);

            return new Reservation(id, c, b);
        }
    }
}
