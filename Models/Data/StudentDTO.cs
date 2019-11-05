using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedSchoolManagment.Models.Data
{
    [Table("Students")]
    public class StudentDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public virtual ApplicationUserDTO User { get; set; }  
        public virtual ICollection<StudentParentDTO> Parents { get; set; }
        public virtual ClassDTO Class { get; set; } 
        public virtual ICollection<MarksDTO> Marks { get; set; }
        public virtual ICollection<RebukeDTO> Rebukes { get; set; }
    }
}
