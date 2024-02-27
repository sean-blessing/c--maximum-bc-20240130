using System.Data;
using System.Data.SqlClient;

namespace MovieDB {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, BMDB!!");

            string connStr = "Server=localhost;Database=bmdb;Integrated Security=True";
            string sqlCommand = "SELECT * FROM Movie";

            Console.WriteLine("Connecting to database...");
            using (SqlConnection conn = new SqlConnection(connStr)) {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sqlCommand, conn)) {
                    Console.WriteLine("Sending SQL command...");
                    SqlDataReader dr = cmd.ExecuteReader();

                    Console.WriteLine("Reading data...");
                    while (dr.Read()) {
                        Console.WriteLine($"Movie: {dr["Id"]} {dr["Title"]} Company: {dr["Year"]}");
                    }

                }

            }
            Console.WriteLine("bye");
        }
    }
}
