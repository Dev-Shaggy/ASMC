using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedSchoolManagment.Models.Data
{
    public class TimetableDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int WeekDay { get; set; }
        public virtual LessonHoursDTO Hour { get; set; }
        public virtual ICollection<LessonDTO> Lessons { get; set; }
    }
}
