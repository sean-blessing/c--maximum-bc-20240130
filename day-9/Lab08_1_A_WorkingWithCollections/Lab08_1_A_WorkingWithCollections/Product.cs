using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_1_A_WorkingWithCollections {
    internal class Product {

        // samples to build random products
        private string[] categories = {"Wrench","Hammer","Saw", "Screw driver",
        "Toolbox","Vise", "Ruler", "Scraper"};
        private string[] colors = { "", "", "", "", "", "",
            "Black", "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed",
            "DarkMagenta", "DarkYellow", "Gray", "DarkGray", "Blue",
            "Green", "Cyan", "Red", "Magenta", "Yellow", "White" };
        private string[] sizes = { "", "Small", "Medium", "Large", "Extra Large" };
        private string[] statuses = { "Active", "Inactive", "Deprecated", "Pending" };

                // constructors
        public Product() {
        }

        // properties
        public int ProductID { get; set; }
        public string CatalogNumber { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QtyOnHand { get; set; }
        public string Status { get; set; }

        // methods
        public void CreateRandomProductProperties() {
            Random rand = new Random();

            this.ProductID = rand.Next(1, 10000);

            string category = categories[rand.Next(categories.Length)];
            this.CatalogNumber = category.Substring(0, 2).ToUpper() +
                                 category.Substring(category.Length - 1).ToUpper() +
                                 ProductID.ToString("000000");

            this.Name = sizes[rand.Next(sizes.Length)] + " " +
                        colors[rand.Next(colors.Length)] + " " +
                        category;
            // remove any excess spaces due to blank categories or colors
            this.Name = this.Name.Replace("  ", " ").Trim();

            this.Price = (decimal)(rand.NextDouble() * 1000);

            this.QtyOnHand = rand.Next(0, 10000);

            this.Status = statuses[rand.Next(statuses.Length)];
        }
    }
}
