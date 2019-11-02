using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AdvancedSchoolManagment.Models.Data
{
    [Table("StudentsParents")]
    public class StudentParentDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public virtual StudentDTO Student { get; set; }
        public virtual ParentDTO Parent { get; set; }
    }
}
