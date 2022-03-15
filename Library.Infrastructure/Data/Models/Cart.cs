using System.ComponentModel.DataAnnotations;

namespace Library.Infrastructure.Data.Models
{
    public class Cart
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; }

        [Required]
        [StringLength(36)]
        public string ReaderCardId { get; set; }

        public ICollection<Book> Books { get; set; }

        public Cart()
        {
            Books = new List<Book>();
        }
    }
}
