using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels;

namespace kanakketuppuapiservice.Mappers.ContactService
{
    public class ContactServiceControllerMapper : IContactServiceControllerMapper
    {
        public CreateContactMsgEntity MapCreateContactMsgEntity(ContactApiModel contactApiModel)
        {
            if (contactApiModel == null)
            {
                return new CreateContactMsgEntity();
            }
            return new CreateContactMsgEntity()
            {
                CustomerName = contactApiModel.CustomerName,
                EmailAddress = contactApiModel.EmailAddress,
                Message = contactApiModel.Message,
                Subject = contactApiModel.Subject
            };
        }
    }
}