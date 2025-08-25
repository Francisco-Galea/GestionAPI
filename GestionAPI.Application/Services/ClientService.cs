using GestionAPI.Application.DTOs.Request;
using GestionAPI.Application.Interfaces.IRepository;
using GestionAPI.Application.Interfaces.IService;
using GestionAPI.Domain.Entities;

namespace GestionAPI.Application.Services
{
    public class ClientService : IClientService
    {

        private readonly IClientRepository repository;

        public ClientService(IClientRepository repository)
        {
            this.repository = repository;
        }

        public async Task CreateClientAsync(ClientRequest clientRequest)
        
        {
            ClientEntity client = new ClientEntity() { 
                ClientName = clientRequest.ClientName, 
                ClientEmail = clientRequest.ClientEmail 
            };
            await repository.InsertAsync(client);
        }

        public async Task DeleteClientAsync(int clientId)
        {
            await repository.LogicalDeleteAsync(clientId);
        }

        public async Task<List<ClientEntity>> GetAllClientsAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<ClientEntity> GetClientByIdAsync(int clientId)
        {
            return await repository.GetByIdAsync(clientId);
        }

        public async Task UpdateClientAsync(int clientId, ClientRequest clientRequest)
        {
            ClientEntity client = new ClientEntity() { 
                ClientId = clientId, 
                ClientName = clientRequest.ClientName, 
                ClientEmail = clientRequest.ClientEmail 
            };
            await repository.UpdateAsync(client);
        }
    }
}
