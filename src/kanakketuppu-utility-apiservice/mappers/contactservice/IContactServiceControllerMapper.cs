using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceModel.CommonModels;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels;

namespace kanakketuppuapiservice.Mappers.ContactService
{
    public interface IContactServiceControllerMapper
    {
        CreateContactMsgEntity MapCreateContactMsgEntity(ContactApiModel contactApiModel);

        ContactApiResponseModel MapContactApiResponseModel(List<ErrorMessage> errorMessage, CreateContactMsgEntity createContactMsgEntity);

        DeleteContactByIdMsgEntity MapDeleteContactByIdMsgEntity(string id);
    }
}