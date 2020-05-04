using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class Variant
    {
        [Key]
        public int VariantId { get; set; }
        [Required]
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        [Required]
        public Question Question { get; set; }
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        public bool IsTrue { get; set; }
    }
}