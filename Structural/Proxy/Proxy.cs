

namespace Proxy
{
    public class Proxy : IService
    {
        private Service service;
        public Proxy(Service service)
        {
            this.service = service;
        }

        public string Balance(string account)
        {
            if (string.IsNullOrEmpty(account))
            {
                return "Error. Account can not be empty";
            }

          return  service.Balance(account);
        }
    }
}
