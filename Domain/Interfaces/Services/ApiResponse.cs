namespace Domain.Interfaces.Services
{
    public class ApiResponse<T>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public ICollection<T>? Data { get; set; } = new List<T>();

        public ApiResponse() { }
    }
}
