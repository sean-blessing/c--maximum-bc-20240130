using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrsWebNet.Models {
	[Table("Product")]
    public class Product {
		[Key]
        public int Id { get; set; }

		//[ForeignKey("Vendor")]
		public int VendorId { get; set; }
		public string PartNumber { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string Unit { get; set; }
		public string? PhotoPath { get; set; }

        public Vendor Vendor { get; set; }

    }

}
