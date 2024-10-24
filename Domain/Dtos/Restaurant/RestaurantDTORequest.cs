using Domain.Dtos.Address;

namespace Domain.Dtos.Restaurant
{
    public class RestaurantDTORequest : RestaurantDTOBase
    {
        public AddressDTORequest Address { get; set; }
        public RestaurantDTORequest() { }
    }
}
