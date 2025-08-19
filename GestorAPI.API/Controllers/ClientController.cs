using GestionAPI.Application.DTOs;
using GestionAPI.Application.Interfaces.IService;
using GestionAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GestionAPI.API.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        private readonly IClientService clientService;

        public ClientController(IClientService clientService)
        {
            this.clientService = clientService;
        }

        [HttpGet]
        public async Task<List<ClientEntity>> GetAllClients()
        {
            return await clientService.GetAllClientsAsync();
        }

        [HttpGet("{id}")]
        public async Task<ClientEntity> GetClientById(int id)
        {
            return await clientService.GetClientByIdAsync(id);
        }

        [HttpPost]
        public async Task CreateClient([FromBody] ClientRequest clientRequest)
        {
            await clientService.CreateClientAsync(clientRequest);
        }

        [HttpPut("{id}")]
        public async Task UpdateClient(int id, [FromBody] string name, string mail)
        {
            await clientService.UpdateClientAsync(id, name, mail);
        }

        [HttpDelete("{id}")]
        public async Task DeleteClient(int id)
        {
            await clientService.DeleteClientAsync(id);
        }
    }
}
