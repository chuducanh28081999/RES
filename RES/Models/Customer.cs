using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RES.Models
{
    [Table("Customer",Schema = "public")]
    class Customer
    {
        [Key]
        [Column("cus_uid", Order = 0)]
        public Guid cus_uid { get; set; }
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
        public DateTime lastvisited { get; set; }
        [Required]
        public DateTime created { get; set; }
        [Required]
        public DateTime modified { get; set; }
        [Required]
        public Int16 status { get; set; }
    }
}
