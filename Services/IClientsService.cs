using WebRegistration.Models;

namespace WebRegistration.Services;

public interface IClientService
{
    List<Client> GetAll();
    Client Get(int id);
    void Save(Client client);
}
