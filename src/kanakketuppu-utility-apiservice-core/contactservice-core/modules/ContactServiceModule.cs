using Autofac;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Mappers;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.PostProcessors;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Processors;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Services;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Validations;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Verifiers;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Modules
{
    public class ContactServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ContactServiceMapper>().As<IContactServiceMapper>();
            builder.RegisterType<ContactServicePostProcessor>().As<IContactServicePostProcessor>();
            builder.RegisterType<ContactServiceProcessor>().As<IContactServiceProcessor>();
            builder.RegisterType<ContactServiceRepository>().As<IContactServiceRepository>();
            builder.RegisterType<ContactService>().As<IContactService>();
            builder.RegisterType<ContactServiceValidation>().As<IContactServiceValidation>();
            builder.RegisterType<ContactServiceVerifier>().As<IContactServiceVerifier>();
            builder.RegisterType<ContactServiceErrorCode>().As<IContactServiceErrorCode>();
        }
    }
}