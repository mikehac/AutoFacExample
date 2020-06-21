using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore31.Interfaces;
using WebApplicationCore31.Services;

namespace WebApplicationCore31
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Service1>().As<IService1>();
            builder.RegisterType<Service2>().As<IService2>();
            builder.RegisterType<Generic>().As<IGeneric>().WithParameter("apiName", "From Service 1");
            builder.RegisterType<Generic>().As<IGeneric>().WithParameter("apiName", "From Service 2");
        }
    }
}
