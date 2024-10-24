using AutoMapper;
using Domain.Dtos.Address;
using Domain.Entities;

namespace Domain.Mappers
{
    public class AddressMapper : Profile
    {
        public AddressMapper()
        {
            CreateMap<AddressDTORequest, Address>();
            CreateMap<Address, AddressDTOResponse>();
        }
    }
}
