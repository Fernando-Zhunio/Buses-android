using System.ComponentModel.DataAnnotations;

namespace buses2.Models
{
    public class Driver
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
