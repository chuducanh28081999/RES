using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RES.Models
{
    [Table("Order", Schema = "public")]
    class Order
    {
        [Key]
        [Column("or_uid", Order = 0)]
        public Guid or_uid { get; set; }
        [Required]
        public DateTime created { get; set; }
        [Required]
        public Int16 status { get; set; }
        [Column("tb_uid", Order = 1)]
        public Guid tb_uid { get; set; }
        [ForeignKey("tb_uid")]
        public Table Table { get; set; }
        [Column("emp_uid", Order = 2)]
        public Guid emp_uid { get; set; }
        [ForeignKey("emp_uid")]
        public Employee Employee { get; set; }
    }
}
