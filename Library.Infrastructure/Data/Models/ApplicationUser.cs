using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Library.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(60)]
        public string LastName { get; set; }
    }
}
