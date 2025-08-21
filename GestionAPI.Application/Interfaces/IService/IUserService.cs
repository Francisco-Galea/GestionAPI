using GestionAPI.Application.DTOs.Request;
using GestionAPI.Domain.Entities;

namespace GestionAPI.Application.Interfaces.IService
{
    public interface IUserService
    {
        Task CreateUser(UserRequest userRequest);
        Task UpdateUser(int userId, UserRequest userRequest);
        Task<UserEntity> GetUserById(int userId);
        Task<List<UserEntity>> GetAllUsers();
        Task DeleteUser(int userId);
    }
}
