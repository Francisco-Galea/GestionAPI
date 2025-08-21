
namespace GestionAPI.Application.Interfaces.IService
{
    public interface IPasswordService
    {
        Task<string> HashPassword(string password);
        Task<bool> VerifyPassword(string password, string hash);
    }
}
