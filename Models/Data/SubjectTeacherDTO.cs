using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdvancedSchoolManagment.Models.Data
{
    [Table("SubjectsTeachers")]
    public class SubjectTeacherDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public virtual SubjectDTO Subject { get; set; }
        public virtual TeacherDTO Teacher { get; set; }

    }
}
