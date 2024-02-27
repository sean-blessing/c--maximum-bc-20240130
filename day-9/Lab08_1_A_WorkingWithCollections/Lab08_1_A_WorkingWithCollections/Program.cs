namespace Lab08_1_A_WorkingWithCollections {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Generic Collections!");

            //// display column headings
            //Console.WriteLine(
            //                  $"{"ID",-6} " +
            //                  $"{"Catalog",-9} " +
            //                  $"{"Name",-34}" +
            //                  $"{"Price",9}" +
            //                  $"{"   Qty",6}" +
            //                  $"{"Status",10}"
            //                 );
            //Console.WriteLine();  // blank line

            //// Create a few sample Products
            //for (int i = 0; i < 100; i++) {
            //    Product prod = new Product();
            //    prod.CreateRandomProductProperties();

            //    Console.WriteLine(
            //                       $"{prod.ProductID,6} " +
            //                       $"{prod.CatalogNumber,-9} " +
            //                       $"{prod.Name,-34} " +
            //                       $"{prod.Price,9:N2} " +
            //                       $"{prod.QtyOnHand,6:N0} " +
            //                       $"{prod.Status,-10} "
            //                     );
            //}

            //List<Product> products = new List<Product>();
            List<Product> products = new();

            for (int i = 0; i < 50; i++) {
                Product prod = new Product();
                prod.CreateRandomProductProperties();
                products.Add(prod);
            }

            Console.WriteLine($"# in List: {products.Count}");

            Console.WriteLine($"5th item in list is {products[4].Name}.");

            Console.WriteLine(
                              $"{"ID",-6} " +
                              $"{"Catalog",-9} " +
                              $"{"Name",-34}" +
                              $"{"Price",9}" +
                              $"{"   Qty",6}" +
                              $"{"Status",10}"
                             );
            foreach (Product prod in products) {
                Console.WriteLine(
                                   $"{prod.ProductID,6} " +
                                   $"{prod.CatalogNumber,-9} " +
                                   $"{prod.Name,-34} " +
                                   $"{prod.Price,9:N2} " +
                                   $"{prod.QtyOnHand,6:N0} " +
                                   $"{prod.Status,-10} "
                                 );
            }


            Console.WriteLine("\n =========== Sorted List =============\n");
            products.Sort((x, y) => x.ProductID.CompareTo(y.ProductID));
            Console.WriteLine(
                              $"{"ID",-6} " +
                              $"{"Catalog",-9} " +
                              $"{"Name",-34}" +
                              $"{"Price",9}" +
                              $"{"   Qty",6}" +
                              $"{"Status",10}"
                             );
            foreach (Product prod in products) {
                Console.WriteLine(
                                   $"{prod.ProductID,6} " +
                                   $"{prod.CatalogNumber,-9} " +
                                   $"{prod.Name,-34} " +
                                   $"{prod.Price,9:N2} " +
                                   $"{prod.QtyOnHand,6:N0} " +
                                   $"{prod.Status,-10} "
                                 );
            }

            Console.WriteLine("\n =========== Deprecated Products List =============\n");
            var deprecatedProducts = products.FindAll(p => p.Status == "Deprecated");
            Console.WriteLine(
                              $"{"ID",-6} " +
                              $"{"Catalog",-9} " +
                              $"{"Name",-34}" +
                              $"{"Price",9}" +
                              $"{"   Qty",6}" +
                              $"{"Status",10}"
                             );
            foreach (Product prod in deprecatedProducts) {
                Console.WriteLine(
                                   $"{prod.ProductID,6} " +
                                   $"{prod.CatalogNumber,-9} " +
                                   $"{prod.Name,-34} " +
                                   $"{prod.Price,9:N2} " +
                                   $"{prod.QtyOnHand,6:N0} " +
                                   $"{prod.Status,-10} "
                                 );
            }

            Console.WriteLine("\n =========== Deprecated, $100+, Red Products List =============\n");
            var filteredProducts = products.FindAll(p => 
                p.Status == "Deprecated" && p.Price > 100 && p.Name.Contains("Red")
            );
            Console.WriteLine(
                              $"{"ID",-6} " +
                              $"{"Catalog",-9} " +
                              $"{"Name",-34}" +
                              $"{"Price",9}" +
                              $"{"   Qty",6}" +
                              $"{"Status",10}"
                             );
            foreach (Product prod in filteredProducts) {
                Console.WriteLine(
                                   $"{prod.ProductID,6} " +
                                   $"{prod.CatalogNumber,-9} " +
                                   $"{prod.Name,-34} " +
                                   $"{prod.Price,9:N2} " +
                                   $"{prod.QtyOnHand,6:N0} " +
                                   $"{prod.Status,-10} "
                                 );
            }

            Dictionary<string, Product> productDict = new Dictionary<string, Product>();

            // I'm reusing the products list, rather than creating new products in the dictionary
            for (int i = 0; i < products.Count; i++) {
                productDict.Add(products[i].CatalogNumber, products[i]);
            }

            Console.WriteLine("\n =========== Dictionary keys =============\n");
            foreach (string prodKey in productDict.Keys) {
                Console.WriteLine(prodKey);
            }

            Console.Write("Enter key to find: ");
            string theKey = Console.ReadLine();

            Product prod1;
            if (productDict.TryGetValue(theKey, out prod1)) {
                Console.WriteLine($"  Found: {prod1.Name} with {prod1.QtyOnHand} in stock.");
            }
            else {
                Console.WriteLine($"  Product {theKey} not found!");
            }

            Console.WriteLine("bye");
        }
    }
}
