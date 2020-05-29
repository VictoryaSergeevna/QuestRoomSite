using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Laba_14EntityASP.Models;
using Laba_14EntityASP.Repositories;
using Laba_14EntityASP.EF;
using System.Reflection;

namespace Laba_14EntityASP.Utils
{
    public class AutofacRegistation
    {
        public static void Register() {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.Register(ctor => new QuestRoomRepository()).As<IRepository<QuestRoom>>().SingleInstance();
            builder.Register(ctor => new PhoneRepository()).As<IRepository<Phone>>().SingleInstance();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}