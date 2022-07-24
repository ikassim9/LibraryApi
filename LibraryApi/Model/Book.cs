using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LibraryApi.Model
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string? Title { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Author { get; set; }
 
        
    }
}
