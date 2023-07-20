using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required!")]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
