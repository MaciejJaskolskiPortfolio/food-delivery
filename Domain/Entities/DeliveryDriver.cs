using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class DeliveryDriver
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
