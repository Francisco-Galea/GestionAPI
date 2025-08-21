using GestionAPI.Application.Interfaces.IService;

namespace GestionAPI.Application.Services
{
    public class PasswordService : IPasswordService
    {
        public async Task<string> HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public async Task<bool> VerifyPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }

    }
}
