using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RES.Models
{
    [Table("Reservetion", Schema="public")]
    class Reservetion
    {
        [Key]
        [Column("res_uid", Order = 0)]
        public Guid res_uid { get; set; }
        [Required]
        public DateTime timeofreservetion { get; set; }
        [Required]
        public int peoplecount { get; set; }
        public string notes { get; set; }
        [Required]
        public DateTime checkintime { get; set; }
        [Required]
        public Int16 status { get; set; }
        [Required][Column(Order = 1)]
        public Guid cus_uid { get; set; }
        [ForeignKey("cus_uid")]
        public Customer Customer { get; set; }
    }
}
