using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RES.Models
{
    [Table("Account", Schema="public")]
    class Account
    {
        [Key]
        [Column("ac_uid", Order = 0)]
        public Guid ac_uid { get; set; }
        [Required][MaxLength(50)]
        public string username { get; set; }
        [Required][MaxLength(50)]
        public string password { get; set; }
        [Required]
        public int role { get; set; }
        [Required]
        public DateTime created { get; set; }
        [Required]
        public DateTime modified { get; set; }
        [Required]
        public Int16 status { get; set; }
    }
}
