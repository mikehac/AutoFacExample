using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore31.Interfaces;

namespace WebApplicationCore31.Services
{
    public class Service1 : IService1
    {
        IGeneric _generic;

        public Service1(IGeneric generic)
        {
            _generic = generic;
        }

        public string GetValue()
        {
            return "Hello from Service1. " + _generic.GetGenericValue();
        }
    }
}
