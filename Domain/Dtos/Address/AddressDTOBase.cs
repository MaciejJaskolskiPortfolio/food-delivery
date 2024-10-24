namespace Domain.Dtos.Address
{
    public abstract class AddressDTOBase
    {
        public int? Id { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string HouseNumber { get; set; }
        public string? ApartmentNumber { get; set; }
        public string PostalCode { get; set; }
        public string? AdditionalInfo { get; set; }
    }
}
