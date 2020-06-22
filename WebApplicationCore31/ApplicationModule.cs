using Autofac;
using Autofac.Core;
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
            builder.RegisterType<Generic>().As<IGeneric>().WithParameter("apiName", "From Service 1").Keyed<IGeneric>("Service1");
            builder.RegisterType<Generic>().As<IGeneric>().WithParameter("apiName", "From Service 2").Keyed<IGeneric>("Service2");
            builder.RegisterType<Service1>().As<IService1>()
                .WithParameter(new ResolvedParameter(
                        (pi, ctx) => pi.ParameterType == typeof(IGeneric),
                        (pi, ctx) => ctx.ResolveKeyed<IGeneric>("Service1")
                    ));
            builder.RegisterType<Service2>().As<IService2>()
                .WithParameter(new ResolvedParameter(
                        (pi, ctx) => pi.ParameterType == typeof(IGeneric),
                        (pi, ctx) => ctx.ResolveKeyed<IGeneric>("Service2")));
        }
    }
}
