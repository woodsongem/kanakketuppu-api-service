using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels;
using KanakketuppuUtilityApiServiceCore.Utility;

namespace kanakketuppuapiservice.Mappers.ContactService
{
    public class ContactServiceControllerMapper : IContactServiceControllerMapper
    {
        public ContactApiResponseModel MapContactApiResponseModel(Result result, CreateContactMsgEntity createContactMsgEntity)
        {
            var contactApiResponseModel = new ContactApiResponseModel();
            if (result.ResultStatus != Status.Success)
            {
                contactApiResponseModel.ErrorMessages = result.ErrorMessages.ToApiErrorMessage();
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
    }
}