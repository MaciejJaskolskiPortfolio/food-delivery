using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(128)]
        public string? Description { get; set; }

        public virtual Address Address { get; set; }

        public RestaurantStatus Status { get; set; } = RestaurantStatus.NOT_PUBLISHED;

        public ICollection<MenuItem> MenuItems { get; set; }

        public Restaurant() { }
    }
}
