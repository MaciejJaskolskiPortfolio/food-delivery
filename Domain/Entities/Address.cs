using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Street { get; set; }

        [Required]
        [MaxLength(6)]
        public string HouseNumber { get; set; }

        [MaxLength(6)]
        public string? ApartmentNumber { get; set; }

        [MaxLength(32)]
        [Required]
        public string City { get; set; }

        [MaxLength(12)]
        [Required]
        public string PostalCode { get; set; }

        [MaxLength(128)]
        public string? AdditionalInfo { get; set; }

        public virtual Restaurant? Restaurant { get; set; }
        public virtual int? RestaurantId { get; set; }
    }
}
