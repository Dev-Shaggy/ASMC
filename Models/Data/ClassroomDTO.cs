using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedSchoolManagment.Models.Data
{
    [Table("Classrooms")]
    public class ClassroomDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual TeacherDTO Teacher { get; set; }
        public string Name { get; set; }
        public virtual SubjectDTO Subject { get; set; }
    }
}
