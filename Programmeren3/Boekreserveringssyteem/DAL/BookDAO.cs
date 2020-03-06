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
    public class BookDAO
    {
        private SqlConnection dbConnection;

        public BookDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["Boekreserveringsysteem"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<Book> GetAll()
        {
            dbConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Books", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();

            while (reader.Read())
            {
                Book b = ReadBook(reader);
                books.Add(b);
            }

            reader.Close();
            dbConnection.Close();

            return books;
        }

        public Book GetById(int bookId)
        {
            dbConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Books WHERE Id = @Id", dbConnection);
            cmd.Parameters.AddWithValue("@Id", bookId);

            SqlDataReader reader = cmd.ExecuteReader();
            Book book = null;

            if (reader.Read())
                book = ReadBook(reader);

            reader.Close();
            dbConnection.Close();

            return book;
        }

        private Book ReadBook(SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string author = (string)reader["Author"];
            string title = (string)reader["Title"];

            return new Book(id, title, author);
        }
    }
}
