using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Utils.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }
        [Column("created")]
        public DateTime Created { get; set; } = DateTime.UtcNow;

        [Column("lastmodified")]
        public DateTime LastModified { get; set; } = DateTime.UtcNow;
    }

    public abstract class AuditableEntity : BaseEntity
    {
        [Column("createdby")]
        public long CreatedBy { get; set; }
        [Column("modifiedby")]
        public long ModifiedBy { get; set; }
    }
}
