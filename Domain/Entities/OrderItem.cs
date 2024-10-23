using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public uint Quantity { get; set; }

        public decimal Price { get; set; }

        public ICollection<OrderItemOption> OrderItemOptions { get; set; }
    }
}
