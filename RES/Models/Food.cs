using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RES.Models
{
    [Table("Food", Schema = "public")]
    class Food
    {
        [Key]
        [Column("food_uid", Order = 0)]
        public Guid food_uid { get; set; }
        [Required][MaxLength(100)]
        public string foodname { get; set; }
        [Required]
        public int type { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public DateTime created { get; set; }
        [Required]
        public DateTime modified { get; set; }
        [Required]
        public Int16 status { get; set; }
    }
}
