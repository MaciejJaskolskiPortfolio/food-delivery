using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class MenuItemOption
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public int MenuItemCategoryId { get; set; }
        public MenuItemCategory MenuItemCategory { get; set; }
    }
}
