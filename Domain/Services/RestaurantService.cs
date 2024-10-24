using AutoMapper;
using Domain.Dtos.Restaurant;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Newtonsoft.Json;
using Serilog;
using System.Text.Json.Serialization;

namespace Domain.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _repository;
        private readonly IMapper _mapper;

        public RestaurantService(IRestaurantRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse<RestaurantDTOResponse>> Create(RestaurantDTORequest restaurant)
        {
            try
            {
                var restaurantEntity = _mapper.Map<Restaurant>(restaurant);
                var createdRestaurant = await _repository.Create(restaurantEntity);
                Log.Debug($"Created restaurant id={createdRestaurant.Id}");

                var restaurantResponse = _mapper.Map<RestaurantDTOResponse>(createdRestaurant);
                return new ApiResponse<RestaurantDTOResponse> { Data = [restaurantResponse], Status = StatusCodes.Status201Created };
            }
            catch (Exception ex)
            {
                Log.Error($"Something went wrong while creating restaurant {JsonConvert.SerializeObject(restaurant)} {ex.Message} {ex.StackTrace}");
                return new ApiResponse<RestaurantDTOResponse> { Data = [], Status = StatusCodes.Status500InternalServerError, StackTrace = ex.StackTrace, Message = ex.Message };
            }
        }

        public Task<ApiResponse<string>> DeleteRestaurant(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<List<RestaurantDTOResponse>>> GetRestaurants(string cityName)
        {
            try
            {
                var restaurants = await _repository.GetRestaurants(cityName);
                Log.Debug($"Found {restaurants.Count} restaurant in {cityName}");

                var restaurantResponse = _mapper.Map<List<RestaurantDTOResponse>>(restaurants);
                return new ApiResponse<List<RestaurantDTOResponse>> { Data = [restaurantResponse], Status = StatusCodes.Status200OK, Message = $"Restaurant with city name = {cityName}" };
            }
            catch (Exception ex)
            {
                Log.Error($"Error during restaurant {ex.Message} get occured {JsonConvert.SerializeObject(ex.StackTrace)}");
                return new ApiResponse<List<RestaurantDTOResponse>> { Status = StatusCodes.Status500InternalServerError, StackTrace = ex.StackTrace };
            }
        }

        public async Task<ApiResponse<RestaurantDTOResponse>> GetRestaurantById(int id)
        {
            try
            {
                var restaurant = await _repository.GetRestaurantById(id);

                if (restaurant == null)
                {
                    Log.Error($"Could not find restaurant with id={id}");
                    return new ApiResponse<RestaurantDTOResponse> { Data = [], Status = StatusCodes.Status404NotFound, Message = $"Could not find find restaurant with id={id}" };
                }

                Log.Debug($"Found restaurant with id={id}");

                var restaurantResponse = _mapper.Map<RestaurantDTOResponse>(restaurant);
                return new ApiResponse<RestaurantDTOResponse> { Data = [restaurantResponse], Status = StatusCodes.Status200OK, Message = $"Found restaurant with id={id}" };
            }
            catch (Exception ex)
            {
                Log.Error($"Error during restaurant {ex.Message} get occured {JsonConvert.SerializeObject(ex.StackTrace)}");
                return new ApiResponse<RestaurantDTOResponse> { Status = StatusCodes.Status500InternalServerError, StackTrace = ex.StackTrace };
            }
        }

        public Task<ApiResponse<RestaurantDTOResponse>> UpdateRestaurant(int id, RestaurantDTORequest restaurant)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<RestaurantDTOResponse>> UpdateRestaurantStatus(int id, RestaurantStatusDTORequest restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
