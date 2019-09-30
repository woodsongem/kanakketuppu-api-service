using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels;

namespace kanakketuppuapiservice.Mappers.ContactService
{
    public interface IContactServiceControllerMapper
    {
        CreateContactMsgEntity MapCreateContactMsgEntity(ContactApiModel contactApiModel);

        ContactApiResponseModel MapContactApiResponseModel(List<ErrorMessage> errorMessage, CreateContactMsgEntity createContactMsgEntity);
    }
}