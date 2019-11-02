using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdvancedSchoolManagment.Models.Data
{
    [Table("Teachers")]
    public class TeacherDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public virtual WorkerDTO Worker { get; set; }
        public virtual ClassroomDTO Classroom { get; set; }
        public virtual ICollection<SubjectTeacherDTO> Subjects { get; set; }
        public Guid ClassId { get; set; }
        [ForeignKey("ClassId")]
        public virtual ClassDTO Class { get; set; }
        public virtual ICollection<MarksDTO> Marks { get; set; }
    }
}
