using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedSchoolManagment.Models.Data
{
    [Table("MarksSchema")]
    public class MarkSchemaDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Column(TypeName = "decimal(4,2)")]
        public decimal Value { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MarksDTO> Marks { get; set; }
    }
}
