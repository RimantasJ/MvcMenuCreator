using System.ComponentModel.DataAnnotations;

namespace MvcMenuCreator.Models
{
    public class MenuItem
    {
        public int Id { get; set; }


        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; }


        [StringLength(20, MinimumLength = 4)]
        [RegularExpression(@"^[A-Z][a-z]*$")]
        public string Category { get; set; }


        [Range(0, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }


        public bool IsVegan { get; set; }
    }
}
