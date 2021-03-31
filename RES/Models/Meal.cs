using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RES.Models
{
    [Table("Meal", Schema = "public")]
    class Meal
    {
        [Key]
        [Column("meal_uid", Order = 0)]
        public Guid eal_uid { get; set; }
        [Required]
        public DateTime created { get; set; }
        [Required]
        public Int16 status { get; set; }
    }
}
