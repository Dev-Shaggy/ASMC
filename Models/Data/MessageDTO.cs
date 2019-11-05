using System.Collections;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedSchoolManagment.Models.Data
{
    [Table("Messages")]
    public class MessageDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Topic { get; set; }
        public string Message { get; set; }
        [InverseProperty("Sender")]
        public ApplicationUserDTO Sender { get; set; }
        [InverseProperty("Receiver")]
        public ApplicationUserDTO Receiver { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        public bool Showed { get; set; }
        public MessageDTO MainMessage { get; set; }

    }
}
