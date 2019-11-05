using System.Collections;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedSchoolManagment.Models.Data
{
    [Table("Lessons")]
    public class LessonDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public virtual ClassDTO Class { get; set; }
        public virtual ClassroomDTO Classroom { get; set; }
        public virtual SubjectDTO Subject { get; set; }
        public virtual TeacherDTO Teacher { get; set; }
        public virtual ICollection<AbsenceDTO> Absences { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public virtual TimetableDTO Timetable { get; set; }
        public virtual ICollection<RebukeDTO> Rebukes { get; set; }
        

    }
}
