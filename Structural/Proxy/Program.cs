using System;

namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Service service = new Service();
            Proxy proxy = new Proxy(service);
            
            string account = "123";
            Console.WriteLine(GetBalance(proxy, account));

            account = "";
            Console.WriteLine(GetBalance(proxy, account));

        }

        public static string GetBalance(IService service, string account)
        {
            return service.Balance(account);
        }
    }
}
