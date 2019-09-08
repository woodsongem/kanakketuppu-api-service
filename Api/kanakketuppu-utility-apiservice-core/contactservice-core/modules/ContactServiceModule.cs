using System;
using Autofac;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Mappers;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.PostProcessors;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Processors;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Services;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Validations;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Verifiers;

namespace kanakketuppu_utility_apiservice_core.contactservice_core.modules
{
    public class ContactServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IContactServiceMapper>().As<IContactServiceMapper>().InstancePerLifetimeScope();
            builder.RegisterType<IContactServicePostProcessor>().As<ContactServicePostProcessor>().InstancePerLifetimeScope();
            builder.RegisterType<IContactServiceProcessor>().As<ContactServiceProcessor>().InstancePerLifetimeScope();
            builder.RegisterType<IContactServiceRepository>().As<ContactServiceRepository>().InstancePerLifetimeScope();
            builder.RegisterType<IContactService>().As<ContactService>().InstancePerLifetimeScope();
            builder.RegisterType<IContactServiceValidation>().As<ContactServiceValidation>().InstancePerLifetimeScope();
            builder.RegisterType<IContactServiceVerifier>().As<ContactServiceVerifier>().InstancePerLifetimeScope();
        }
    }
}