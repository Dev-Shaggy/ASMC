using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedSchoolManagment.Models.Data
{
    [Table("Marks")]
    public class MarksDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Column(TypeName = "decimal(4,2)")]
        public decimal Weight { get; set; }
        public string Description { get; set; }
        public virtual StudentDTO Student { get; set; }
        public virtual MarkSchemaDTO MarkSchema { get; set; }
        public virtual TeacherDTO Teacher { get; set; }
        public virtual SubjectDTO Subject { get; set; }   
    }
}
