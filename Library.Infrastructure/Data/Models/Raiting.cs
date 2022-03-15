using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Infrastructure.Data.Models
{
    public class Raiting
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public float Number { get; set; }

        [Required]
        [StringLength(36)]
        public string BookId { get; set; }

        [ForeignKey(nameof(BookId))]
        public virtual Book Book { get; set; }

        [Required]
        [StringLength(36)]
        public string UserId { get; set; }

    }
}