namespace Domain.Dtos.Restaurant
{
    public abstract class RestaurantDTOBase
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
