using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string Street { get; set; }
    }
}
