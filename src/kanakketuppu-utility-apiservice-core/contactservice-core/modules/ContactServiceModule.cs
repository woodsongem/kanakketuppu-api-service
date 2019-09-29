using System;
using Autofac;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Mappers;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.PostProcessors;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Processors;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Services;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Validations;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Verifiers;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Modules
{
    public class ContactServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ContactServiceMapper>().As<IContactServiceMapper>().InstancePerLifetimeScope();
            builder.RegisterType<ContactServicePostProcessor>().As<IContactServicePostProcessor>().InstancePerLifetimeScope();
            builder.RegisterType<ContactServiceProcessor>().As<IContactServiceProcessor>().InstancePerLifetimeScope();
            builder.RegisterType<ContactServiceRepository>().As<IContactServiceRepository>().InstancePerLifetimeScope();
            builder.RegisterType<ContactService>().As<IContactService>().InstancePerLifetimeScope();
            builder.RegisterType<ContactServiceValidation>().As<IContactServiceValidation>().InstancePerLifetimeScope();
            builder.RegisterType<ContactServiceVerifier>().As<IContactServiceVerifier>().InstancePerLifetimeScope();
        }
    }
}