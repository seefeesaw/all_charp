using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace HelloWebApiDemo
{
    public class HelloApiContrller : ApiController
    {
        public string Get()
        {
            return "Hello from Api at " +
                DateTime.Now.ToString();
        }
    }
}
