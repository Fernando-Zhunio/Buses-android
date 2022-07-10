using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace buses2.Models
{
    public class User: IdentityUser
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public int LastName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public string? DocType { get; set; }
        [Required]
        [Remote("DocExist", "User", AdditionalFields = "Id",
                ErrorMessage = "Este documento ya existe")]
        public string? DocNumber { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Email { get; set; }

    }
}
