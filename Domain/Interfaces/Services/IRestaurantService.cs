using Domain.Dtos.Restaurant;

namespace Domain.Interfaces.Services
{
    public interface IRestaurantService
    {
        Task<ApiResponse<RestaurantDTOResponse>> Create(RestaurantDTORequest restaurant);
        Task<ApiResponse<List<RestaurantDTOResponse>>> GetRestaurants(string cityName);
        Task<ApiResponse<RestaurantDTOResponse>> GetRestaurantById(int id);
        Task<ApiResponse<RestaurantDTOResponse>> UpdateRestaurant(int id, RestaurantDTORequest restaurant);
        Task<ApiResponse<RestaurantDTOResponse>> UpdateRestaurantStatus(int id, RestaurantStatusDTORequest restaurant);
        Task<ApiResponse<string>> DeleteRestaurant(int id);
    }
}
