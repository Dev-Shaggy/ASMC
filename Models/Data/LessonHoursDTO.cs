using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedSchoolManagment.Models.Data
{
    [Table("LessonHours")]
    public class LessonHoursDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int Number { get; set; }
        [DataType(DataType.Time)]
        public DateTime BeginTime { get; set; }
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }
        public virtual ICollection<TimetableDTO> Timetable { get; set; }
    }
}
