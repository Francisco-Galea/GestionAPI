using GestionAPI.Application.DTOs.Request;
using GestionAPI.Application.Interfaces.IService;
using GestionAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GestionAPI.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public async Task CreateUser([FromBody] UserRequest userRequest)
        {
            await userService.CreateUser(userRequest);
        }

        [HttpPut("{id}")]
        public async Task UpdateUser(int userId, [FromBody] UserRequest userRequest)
        {
            await userService.UpdateUser(userId, userRequest);
        }

        [HttpGet("{id}")]
        public async Task<UserEntity> GetUserById(int userId)
        {
            return await userService.GetUserById(userId);
        }

        [HttpGet]
        public async Task<List<UserEntity>> GetAllUsers()
        {
            return await userService.GetAllUsers();
        }

        [HttpDelete("{id}")]
        public async Task DeleteUser(int userId)
        {
            await userService.DeleteUser(userId);
        }

    }
}
