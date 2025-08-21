using GestionAPI.Application.DTOs.Request;
using GestionAPI.Application.Interfaces.IRepository;
using GestionAPI.Application.Interfaces.IService;
using GestionAPI.Domain.Entities;

namespace GestionAPI.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository userRepository;
        private readonly IPasswordService passwordService;

        public UserService(IUserRepository userRepository, IPasswordService passwordService)
        {
            this.userRepository = userRepository;
            this.passwordService = passwordService;
        }

        public async Task CreateUser(UserRequest userRequest)
        {
            UserEntity userEntity = new UserEntity()
            {
                UserName = userRequest.UserName,
                UserEmail = userRequest.UserMail,
                UserPassword = await passwordService.HashPassword(userRequest.UserPassword)
            };
            await userRepository.InsertAsync(userEntity);
        }

        public Task DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserEntity>> GetAllUsers()
        {
            return await userRepository.GetAllAsync();
        }

        public async Task<UserEntity> GetUserById(int userId)
        {
            return await userRepository.GetByIdAsync(userId);
        }

        public async Task UpdateUser(int userId, UserRequest userRequest)
        {
            UserEntity userEntity = new UserEntity()
            {
                UserName = userRequest.UserName,
                UserEmail = userRequest.UserMail,
                UserPassword = await passwordService.HashPassword(userRequest.UserPassword)
            };
            await userRepository.UpdateAsync(userEntity);
        }
    }
}
