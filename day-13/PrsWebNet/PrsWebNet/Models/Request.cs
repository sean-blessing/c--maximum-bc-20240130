using System.ComponentModel.DataAnnotations.Schema;

namespace PrsWebNet.Models {
    [Table("Request")]
    public class Request {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public string Justification { get; set; }
        public DateOnly DateNeeded { get; set; }
        public string DeliveryMode { get; set; } = "Pickup";
        public string Status { get; set; } = "New";
        public decimal Total { get; set; } = 0;
        public DateTime SubmittedDate { get; set; } = DateTime.Now;
        public string? ReasonForRejection { get; set; }

        public User? User { get; set; }

    }
}
