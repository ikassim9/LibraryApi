using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApi.Model
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Address { get; set; }
   
    }
}
