using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedSchoolManagment.Models.Data
{
    [Table("Rebukes")]
    public class RebukeDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Description { get; set; }
        public virtual LessonDTO Lesson { get; set; }
        public virtual StudentDTO Student { get; set; }
    }
}
