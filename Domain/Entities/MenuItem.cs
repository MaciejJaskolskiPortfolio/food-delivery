using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public ICollection<MenuItemCategory> MenuItemCategories { get; set; } = new List<MenuItemCategory>();
    }
}
