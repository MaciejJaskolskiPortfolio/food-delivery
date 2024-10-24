using Domain.Dtos.Address;

namespace Domain.Dtos.Restaurant
{
    public class RestaurantDTOResponse : RestaurantDTOBase
    {
        public AddressDTOResponse Address { get; set; }
    }
}
