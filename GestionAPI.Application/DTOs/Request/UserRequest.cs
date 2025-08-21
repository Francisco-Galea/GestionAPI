namespace GestionAPI.Application.DTOs.Request
{
    public class UserRequest
    {
        public string UserName { get; set; } = string.Empty;
        public string UserMail { get; set; } = string.Empty;
        public string UserPassword { get; set; } = string.Empty;
    }
}
