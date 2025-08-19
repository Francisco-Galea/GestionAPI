using GestionAPI.Domain.Entities;
using GestionAPI.Application.DTOs;

namespace GestionAPI.Application.Interfaces.IService
{
    public interface IClientService
    {
        Task CreateClientAsync(ClientRequest clientRequest);
        Task<ClientEntity> GetClientByIdAsync(int clientId);
        Task<List<ClientEntity>> GetAllClientsAsync();
        Task UpdateClientAsync(int clientId, string name, string email);
        Task DeleteClientAsync(int clientId);
    }
}
