using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class OrderItemOption
    {
        [Key]
        public int Id { get; set; }

        public int OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }

        public int MenuItemOptionId { get; set; }
        public MenuItemOption MenuItemOption { get; set; }
    }
}
