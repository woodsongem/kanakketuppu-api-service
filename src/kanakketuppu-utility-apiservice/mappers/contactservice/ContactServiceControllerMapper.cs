using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels;
using KanakketuppuUtilityApiServiceCore.Utility;
using System.Collections.Generic;
using KatavuccolCommon.Extensions;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities;
using KanakketuppuUtilityApiServiceModel.CommonModels;

namespace kanakketuppuapiservice.Mappers.ContactService
{
    public class ContactServiceControllerMapper : IContactServiceControllerMapper
    {
        public ContactApiResponseModel MapContactApiResponseModel(List<ErrorMessage> errorMessage, CreateContactMsgEntity createContactMsgEntity)
        {
            var contactApiResponseModel = new ContactApiResponseModel();
            if (errorMessage.AnyWithNullCheck())
            {
                contactApiResponseModel.ErrorMessages = errorMessage.ToApiErrorMessage();
            }
            contactApiResponseModel.Id = createContactMsgEntity.ContactId;
            return contactApiResponseModel;
        }

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

        public DeleteContactByIdMsgEntity MapDeleteContactByIdMsgEntity(string id)
        {
            return new DeleteContactByIdMsgEntity()
            {
                Id = id
            };
        }
    }
}