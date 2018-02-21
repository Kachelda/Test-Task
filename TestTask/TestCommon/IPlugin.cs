namespace TestCommon
{
    public interface IPlugin
    {
        Client GetClient(int id);
        void UpdateClient(Client client);
        Client AddAge(int age, Client client);
    }
}