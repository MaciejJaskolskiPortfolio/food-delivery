namespace Domain.Dtos.Auth
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public DateTime ValidTo { get; set; }

        public AuthResponse() { }
    }
}
