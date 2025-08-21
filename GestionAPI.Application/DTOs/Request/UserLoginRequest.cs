namespace GestionAPI.Application.DTOs.Request
{
    public class UserLoginRequest
    {
        public string UserEmail { get; set; } = string.Empty;
        public string UserPassword { get; set; } = string.Empty;
    }
}
