using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels;

namespace kanakketuppuapiservice.Mappers.ContactService
{
    public interface IContactServiceControllerMapper
    {
        CreateContactMsgEntity MapCreateContactMsgEntity(ContactApiModel contactApiModel);
    }
}