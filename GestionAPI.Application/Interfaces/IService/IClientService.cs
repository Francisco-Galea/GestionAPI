using GestionAPI.Domain.Entities;
using GestionAPI.Application.DTOs.Request;

namespace GestionAPI.Application.Interfaces.IService
{
    public interface IClientService
    {
        Task CreateClientAsync(ClientRequest clientRequest);
        Task<ClientEntity> GetClientByIdAsync(int clientId);
        Task<List<ClientEntity>> GetAllClientsAsync();
        Task UpdateClientAsync(int clientId, ClientRequest clientRequest);
        Task DeleteClientAsync(int clientId);
    }
}
