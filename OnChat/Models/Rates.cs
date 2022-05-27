using System.ComponentModel.DataAnnotations;
namespace OnChat.Models
{
    public class Rates
    {
        [Required]
        [Range(1, 5, ErrorMessage = "Rate should be between 1-5")]
        public int Rate { get; set; }
        [MaxLength(100, ErrorMessage = "Too much text")]
        public string Feedback { get; set; }
        [Key]
        [Required]
        public string Name { get; set; }

        public string Date { get; set; }
        public string Time { get; set; }
    }
}
