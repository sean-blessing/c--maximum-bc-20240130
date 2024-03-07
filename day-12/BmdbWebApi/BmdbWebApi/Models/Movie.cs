using System.ComponentModel.DataAnnotations.Schema;

namespace BmdbWebApi.Models {
    [Table("Movie")]
    public class Movie {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
    }
}