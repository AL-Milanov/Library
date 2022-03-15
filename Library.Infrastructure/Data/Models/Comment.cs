using System.ComponentModel.DataAnnotations;

namespace Library.Infrastructure.Data.Models
{
    public class Comment
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(150)]
        public string Content { get; set; }

        [Required]
        [StringLength(36)]
        public string BookId { get; set; }

        [Required]
        [StringLength(36)]
        public string UserId { get; set; }

    }
}