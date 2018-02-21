using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Http;
using Newtonsoft.Json;
using TestCommon;

namespace TestRESTService
{
    public class ClientController : ApiController
    {
        private IPlugin somePlugin;

        public ClientController()
        {
            Assembly assembly = Assembly.Load("ServicePlugin");

            Type type = assembly.GetType("ServicePlugin.PluginWithFunctional");

            somePlugin = (IPlugin)Activator.CreateInstance(type);
        }

        // GET api/client/1
        public Client Get(int id)
        {
            return somePlugin.GetClient(id);
            //return JsonConvert.SerializeObject(somePlugin.GetClient(id));
        }

        // POST api/client
        [HttpPost]
        public Client Post(int id, int age)
        {
            Client client = somePlugin.GetClient(id);
            if (client != null)
            {
                return somePlugin.AddAge(age, client);
                
            }
            return client;
        }

    }
}