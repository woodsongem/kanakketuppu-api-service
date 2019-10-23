using System;
using Autofac;
using Autofac.Core;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility;
using KanakketuppuUtilityApiServiceCore.Utility;

namespace KanakketuppuUtilityApiServiceCore.Modules
{
    public class KanakketuppuUtilityApiServiceCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            try
            {
                //builder.Register(c =>
                //{
                //    KanakketuppuExtension.SetContext(c.Resolve<IContactServiceErrorCode>());
                //    return null;
                //});

                //var container = builder.Build();
                //using (var scope = container.BeginLifetimeScope())
                //{
                //    KanakketuppuExtension.SetContext(scope.Resolve<IContactServiceErrorCode>());
                //}
            }
            catch (Exception ex)
            {

            }

        }
    }
}
