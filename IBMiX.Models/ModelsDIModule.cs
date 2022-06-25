using Autofac;
using IBMiX.Model.Common;
using IBMiX.Model.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBMiX.Model
{
    public class ModelsDIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Book>().As<IBook>();
            builder.RegisterType<User>().As<IUser>();
        }
    }
}
