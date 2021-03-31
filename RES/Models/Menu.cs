using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RES.Models
{
    [Table("Menu", Schema = "public")]
    class Menu
    {
        [Key]
        [Column("menu_uid", Order = 0)]
        public Guid menu_uid { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public DateTime created { get; set; }
        [Required]
        public DateTime modified { get; set; }
        [Required]
        public Int16 status { get; set; }

    }
}
