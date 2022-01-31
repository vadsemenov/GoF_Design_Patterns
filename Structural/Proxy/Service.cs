using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Service: IService
    {
        public string Balance(string account)
        {
            return $"Balance for account {account}: 555$";
        }
    }
}
