using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class Variant
    {
        [Key]
        public virtual int VariantId { get; set; }

        [Required]
        [ForeignKey("Question")]
        public virtual int QuestionId { get; set; }

        [Required]
        public virtual Question Question { get; set; }

        [Required]
        [MaxLength(300)]
        public virtual string Description { get; set; }

        [Required]
        public virtual bool IsTrue { get; set; }
    }
}