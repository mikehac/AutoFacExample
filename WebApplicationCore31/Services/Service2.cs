using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore31.Interfaces;

namespace WebApplicationCore31.Services
{
    public class Service2 : IService2
    {
        IGeneric _generic;

        public Service2(IGeneric generic)
        {
            _generic = generic;
        }

        public string GetAnotherValue()
        {
            return "Hello from service2 " + _generic.GetGenericValue();
        }
    }
}
