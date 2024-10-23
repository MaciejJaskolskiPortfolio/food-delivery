using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
