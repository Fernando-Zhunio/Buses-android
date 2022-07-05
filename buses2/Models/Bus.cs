using System.ComponentModel.DataAnnotations;

namespace buses2.Models
{
    public class Bus
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Placa { get; set; }
    }
}
