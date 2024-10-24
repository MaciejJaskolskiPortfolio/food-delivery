using AutoMapper;
using Domain.Dtos.Restaurant;
using Domain.Entities;

namespace Domain.Mappers
{
    public class RestaurantMapper : Profile
    {
        public RestaurantMapper()
        {
            CreateMap<RestaurantDTORequest, Restaurant>();
            CreateMap<RestaurantStatusDTORequest, Restaurant>();
            CreateMap<Restaurant, RestaurantDTOResponse>();
        }
    }
}
