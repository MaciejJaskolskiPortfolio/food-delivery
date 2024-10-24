using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {

        private readonly FoodDeliveryDbContext _context;
        private readonly DbSet<Restaurant> _set;

        public RestaurantRepository(FoodDeliveryDbContext context)
        {
            _context = context;
            _set = context.Set<Restaurant>();
        }

        public async Task<Restaurant> Create(Restaurant restaurant)
        {
            await _set.AddAsync(restaurant);
            await _context.SaveChangesAsync();
            return restaurant;
        }

        public Task DeleteRestaurant(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Restaurant>> GetRestaurants(string cityName)
        {
            return _set.Where(a => a.Address.City.ToLower() == cityName.ToLower()).Include(r => r.Address).ToListAsync();
        }

        public async Task<Restaurant?> GetRestaurantById(int id)
        {
            return await _set.Where(r => r.Id == id).FirstOrDefaultAsync();
        }

        public Task<Restaurant> UpdateRestaurant(int id, Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public Task<Restaurant> UpdateRestaurantStatus(int id, Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
