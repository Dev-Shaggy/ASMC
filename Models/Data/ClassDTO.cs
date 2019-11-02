using System.Collections;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedSchoolManagment.Models.Data
{
    [Table("Classes")]
    public class ClassDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StudentDTO> Students { get; set; }
        public virtual TeacherDTO Teacher { get; set; }
        
    }
}
