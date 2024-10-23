using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class MenuItemCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<MenuItemOption> MenuItemOptions { get; set; } = new List<MenuItemOption>();

        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
