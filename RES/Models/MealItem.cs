using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RES.Models
{
    [Table("MealItem", Schema = "public")]
    class MealItem
    {
        [Key]
        [Column("meal_uid", Order = 0)]
        public Guid meal_uid { get; set; }
        [ForeignKey("meal_uid")]
        public Meal Meal { get; set; }
        [Column("food_uid", Order = 1)]
        public Guid food_uid { get; set; }
        [ForeignKey("food_uid")]
        public Food Food { get; set; }
        [Required]
        public int quantity { get; set; }
    }
}
