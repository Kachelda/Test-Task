using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCommon;

namespace ServicePlugin
{
    public class PluginWithFunctional: IPlugin
    {
        private List<Client> Clients;

        //инициализируем список клиентов
        public PluginWithFunctional()
        {
            Clients = new List<Client>
            {
                new Client(){Id = 1, Age = 31, INN = 123456789, Name = "Client_Test", Profession = "C#Developer", Stage = 0}
            };   
        }

        public Client AddAge(int age, Client client)
        {
            client.Age = age;
            return client;
        }

        public Client GetClient(int id)
        {
            return Clients.FirstOrDefault(a=>a.Id == id);
        }

        public void UpdateClient(Client client)
        {
            
        }

        
    }
}
