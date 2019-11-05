using System.Collections;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdvancedSchoolManagment.Models.Data
{
    [Table("Subjects")]
    public class SubjectDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ClassroomDTO> Classrooms { get; set; }
        public virtual ICollection<SubjectTeacherDTO> Teachers { get; set; }
        public virtual ICollection<MarksDTO> Marks { get; set; }
        public virtual ICollection<LessonDTO> Lessons { get; set; }
        public virtual ICollection<AbsenceDTO> Absences { get; set; }
    }
}
