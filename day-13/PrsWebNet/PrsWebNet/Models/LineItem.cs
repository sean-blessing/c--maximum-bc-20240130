using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrsWebNet.Models {
    [Table("LineItem")]
    public class LineItem {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RequestId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        //navigation properties
        public Request? Request { get; set; }
        public Product? Product { get; set; }
    }
}
