using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Infrastructure.Data.Models
{
    public class Book
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(75)]
        public string Title { get; set; }

        [Required]
        [StringLength(36)]
        public string AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public virtual Author Author { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        [Required]
        public int Quantity { get; set; }

        public ICollection<Comment> Comments{ get; set; }

        public Book()
        {
            Comments = new List<Comment>();
        }
    }
}