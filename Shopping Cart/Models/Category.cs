using System.ComponentModel.DataAnnotations;

namespace Shopping_Cart.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30,ErrorMessage ="length can't be above 30 char")]
        public string Name { get; set; }

    }
}
