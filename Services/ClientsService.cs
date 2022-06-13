using WebRegistration.Models;

namespace WebRegistration.Services;

public class ClientService : IClientService
{
    public List<Client> GetAll() => clients;
    public void Save(Client client)
    {
        if (client.Id != 0)
        {
            var clientToUpdate = clients.FirstOrDefault(c => c.Id == client.Id);
            if (clientToUpdate != null)
            {
                clients.Remove(clientToUpdate);
            }
        }
        else
        {
            client.Id = clients.Max(c => c.Id) + 1;
        }
        clients.Add(client);
    } 

    public Client Get(int id) => clients.FirstOrDefault(c => c.Id == id);


    private List<Client> clients = new (){
        new Client { Id = 1, Name = "john", Email = "johng@gmail.com", Gender = 'M', Dateregistered = "03/10/2023", Selectedeventdays = "DAY 1", AdditionalRequest = "" },
        new Client { Id = 2, Name = "jaky", Email = "jaky@gmail.com", Gender = 'F', Dateregistered = "03/10/2023", Selectedeventdays = "DAY 1", AdditionalRequest = "big room" },
        new Client { Id = 3, Name = "sunny", Email = "sunny@gmail.com", Gender = 'M', Dateregistered = "03/10/2023", Selectedeventdays = "DAY 2", AdditionalRequest = "extended bed" },
        new Client { Id = 4, Name = "cate", Email = "cate@gmail.com", Gender = 'F', Dateregistered = "03/10/2023", Selectedeventdays = "DAY 3", AdditionalRequest = "checkin late" },
        new Client { Id = 5, Name = "apple", Email = "apple@gmail.com", Gender = 'F', Dateregistered = "03/10/2023", Selectedeventdays = "DAY 1", AdditionalRequest = "early checkin" },
        new Client { Id = 6, Name = "stven", Email = "stven@gmail.com", Gender = 'M', Dateregistered = "03/10/2023", Selectedeventdays = "DAY 2", AdditionalRequest = "" },

    };
}


