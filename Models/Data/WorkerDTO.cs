using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AdvancedSchoolManagment.Models.Data
{
    [Table("Workers")]
    public class WorkerDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public virtual ApplicationUserDTO User { get; set; }
        public Guid TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual TeacherDTO Teacher { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal GrossSalary { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartWorkDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndWorkDate { get; set; }
        public string BankAccount { get; set; }

    }
}
