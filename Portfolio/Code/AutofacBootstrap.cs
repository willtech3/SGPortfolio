using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;

namespace Portfolio.Code
{
    public class AutofacBootstrap
    {
        internal static void Init(ContainerBuilder builder)
        {
            builder.RegisterType<Portfolio.Code.InquiryContext>();
            builder.RegisterType<UnitOfWork>()
                .As<IUnitOfWork>().PropertiesAutowired().InstancePerLifetimeScope();
            builder.RegisterType<Repository>()
                .As<IRepository>();
        }
    }
}