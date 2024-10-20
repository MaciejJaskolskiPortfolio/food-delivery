using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly DbSet<Address> _set;
        private readonly FoodDeliveryDbContext _context;

        public AddressRepository(FoodDeliveryDbContext context)
        {
            _context = context;
            _set = _context.Set<Address>();
        }
    }
}
