using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public decimal TotalPrice { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public int DeliveryDriverId { get; set; }
        public DeliveryDriver DeliveryDriver { get; set; }


        public int ClientId { get; set; }
        public Client Client { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
