using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string Street { get; set; }
    }
}
