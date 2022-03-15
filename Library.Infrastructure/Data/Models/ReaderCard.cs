using System.ComponentModel.DataAnnotations;

namespace Library.Infrastructure.Data.Models
{
    public class ReaderCard
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(36)]
        public string UserId { get; set; }

        [Required]
        [StringLength(75)]
        public string ReaderName { get; set; }

        public ICollection<Book> Books { get; set; }

        public ReaderCard()
        {
            Books = new List<Book>();
        }

    }
}
