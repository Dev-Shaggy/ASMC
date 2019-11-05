using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AdvancedSchoolManagment.Models.Data
{
    [Table("Users")]
    public class ApplicationUserDTO : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PESEL { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public Guid? StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual StudentDTO Student {get; set;}
        public Guid? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual ParentDTO Parent { get; set; }

        public Guid? WorkerId { get; set; }
        [ForeignKey("WorkerId")]
        public virtual WorkerDTO Worker { get; set; }

        public virtual ICollection<MessageDTO> Sender { get; set; }
        public virtual ICollection<MessageDTO> Receiver { get; set; }
    }
}
