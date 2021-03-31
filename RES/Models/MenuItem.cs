using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RES.Models
{
    [Table("MenuItem", Schema = "public")]
    class MenuItem
    {
        [Key]
        [Column("menu_uid", Order = 0)]
        public Guid menu_uid { get; set; }
        [ForeignKey("menu_uid")]
        public Menu Menu { get; set; }
        [Required]
        public int discount { get; set; }
        [Required]
        public DateTime added { get; set; }
        [Required]
        [Column("food_uid", Order = 1)]
        public Guid food_uid { get; set; }
        [ForeignKey("food_uid")]
        public Food Food { get; set; }

    }
}
