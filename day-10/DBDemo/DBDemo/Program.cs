using System.Data.SqlClient;

namespace DBDemo {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, C# DBs!!");

            // Using System.Data.SqlClient 4.8.6
            string connStr = "Server=localhost;Database=Products;Integrated Security=True";

            // First query
            string sqlStr = "SELECT ProdID, Name, Price FROM Product;";
            List<Product> products = GetProducts(connStr, sqlStr);

            foreach (var prod in products) {
                Console.WriteLine($"Product: {prod.Name} - Price: {prod.Price}");
            }

            Console.WriteLine("--- Products over $1000 ---");

            // First query
            sqlStr = "SELECT ProdID, Name, Price FROM Product WHERE Price>1000;";
            List<Product> productsFiltered = GetProducts(connStr, sqlStr);

            foreach (var prod in productsFiltered) {
                Console.WriteLine($"Product: {prod.Name} - Price: {prod.Price}");
            }

            Console.WriteLine("bye");
        }

        static List<Product> GetProducts(string connStr, string sqlStr) {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connStr;
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlStr;
            cmd.Connection = conn;

            SqlDataReader productsReader = cmd.ExecuteReader();

            List<Product> prodList = new List<Product>();

            while (productsReader.Read()) {
                //Console.WriteLine($"{productsReader["ProdID"]} is {productsReader["Name"]} and costs {productsReader["Price"]}");
                Product p = new Product();
                p.ProdID = int.Parse(productsReader["ProdID"].ToString());
                p.Name = productsReader["name"].ToString();
                p.Price = decimal.Parse(productsReader["Price"].ToString());

                prodList.Add(p);

            }

            cmd.Dispose();

            conn.Close();

            conn.Dispose();

            return prodList;
        }

    }
}
