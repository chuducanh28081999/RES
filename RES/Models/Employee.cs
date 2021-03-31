using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RES.Models
{
    [Table("Employee", Schema ="public")]
    class Employee
    {
        [Key]
        [Column("emp_uid", Order =0)]
        public Guid emp_uid { get; set; }
        [Required][MaxLength(50)]
        public string firstname { get; set; }
        [Required][MaxLength(50)]
        public string lastname { get; set; }
        [Required]
        public Int16 gender { get; set; }
        [Required]
        public DateTime birthdate { get; set; }
        [Required][MaxLength(100)]
        public string address { get; set; }
        [Required][MaxLength(20)]
        public string phone { get; set; }
        [Required]
        public DateTime startdate { get; set; }
        [Required]
        public DateTime created { get; set; }
        [Required]
        public DateTime modified { get; set; }
        [Required]
        public Int16 status { get; set; }
        [Column("ac_uid", Order =1)]
        public Guid ac_uid { get; set; }
        [ForeignKey("ac_uid")]
        public Account Account { get; set; }
    }
}
