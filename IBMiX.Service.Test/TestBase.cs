using Autofac;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using IBMiX.Model;
using IBMiX.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBMiX.Service.Test
{
    public class TestBase
    {
        protected ILifetimeScope Scope { get; set; }

        public TestBase()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ModelsDIModule());
            builder.RegisterModule(new RepositoryDIModule());
            builder.RegisterModule(new ServiceDIModule());
            builder.RegisterAutoMapper(typeof(ModelsProfile).Assembly);
            var container = builder.Build();
            Scope = container.BeginLifetimeScope();
        }
    }
}
