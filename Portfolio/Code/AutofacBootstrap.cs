using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using Microsoft.Ajax.Utilities;

namespace Portfolio.Code
{
    public class AutofacBootstrap
    {
        internal static void Init(ContainerBuilder builder)
        {
            builder.RegisterType<Portfolio.Code.InquiryContext>();
            builder.RegisterType<Repository>()
                .As<IRepository>().InstancePerLifetimeScope();
        }
    }
}