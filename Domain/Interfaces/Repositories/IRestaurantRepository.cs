using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IRestaurantRepository
    {
        Task<Restaurant> Create(Restaurant restaurant);
        Task<List<Restaurant>> GetRestaurants(string cityName);
        Task<Restaurant?> GetRestaurantById(int id);
        Task<Restaurant> UpdateRestaurant(int id, Restaurant restaurant);
        Task<Restaurant> UpdateRestaurantStatus(int id, Restaurant restaurant);
        Task DeleteRestaurant(int id);
    }
}
