using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedSchoolManagment.Models.Data
{
    [Table("Absences")]
    public class AbsenceDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public virtual StudentDTO Student { get; set; }
        public virtual LessonDTO Lesson { get; set; }
    }
}
