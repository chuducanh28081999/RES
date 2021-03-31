using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RES.Models
{
    [Table("Table", Schema = "public")]
    class Table
    {
        [Key]
        [Column("tb_uid", Order = 0)]
        public Guid tb_uid { get; set; }
        [Required]
        public int capacity { get; set; }
        [Required]
        public int location { get; set; }
        [Required]
        public Int16 status { get; set; }
    }
}
