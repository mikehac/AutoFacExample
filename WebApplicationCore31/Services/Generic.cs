using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore31.Interfaces;

namespace WebApplicationCore31.Services
{
    public class Generic : IGeneric
    {
        private string _apiName;

        public Generic(string apiName)
        {
            _apiName = apiName;
        }

        public string GetGenericValue()
        {
            return string.Format("Hello from generic service, apiName is {0}", _apiName);
        }
    }
}
