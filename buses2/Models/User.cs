using System.ComponentModel.DataAnnotations;

namespace buses2.Models
{
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Birthday { get; set; }
        public string DocType { get; set; }
        public string DocNumber { get; set; }

    }
}
