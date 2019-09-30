using Autofac;
using kanakketuppuapiservice.Mappers.ContactService;

namespace kanakketuppuapiservice.Modules
{
    public class KanakketuppuUtilityApiServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ContactServiceControllerMapper>().As<IContactServiceControllerMapper>();
        }
    }
}