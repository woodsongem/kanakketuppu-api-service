using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceCore.Utility;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Validations
{
    public class ContactServiceValidation : IContactServiceValidation
    {
        public List<ErrorMessage> ValidCreateContact(CreateContactMsgEntity createContactMsgEntity)
        {
            var errorMessages = IsCreateContactMsgEntityValid(createContactMsgEntity);
            errorMessages = IsCustomerNameValid(createContactMsgEntity);
            errorMessages = IsSubjectValid(createContactMsgEntity);
            errorMessages = IsMessageValid(createContactMsgEntity);
            errorMessages = IsEmailAddressValid(createContactMsgEntity);
            return errorMessages;
        }

        public List<ErrorMessage> IsCreateContactMsgEntityValid(CreateContactMsgEntity createContactMsgEntity)
        {
            if (createContactMsgEntity.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.CreateContactMsgEntityIsEmpty);
            return null;
        }

        public List<ErrorMessage> IsCustomerNameValid(CreateContactMsgEntity createContactMsgEntity)
        {
            if (createContactMsgEntity.CustomerName.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.CustomerNameIsEmpty);

            return null;
        }

        public List<ErrorMessage> IsSubjectValid(CreateContactMsgEntity createContactMsgEntity)
        {
            if (createContactMsgEntity.Subject.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.SubjectIsEmpty);
            return null;
        }

        public List<ErrorMessage> IsMessageValid(CreateContactMsgEntity createContactMsgEntity)
        {
            if (createContactMsgEntity.Message.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.MessageIsEmpty);
            return null;
        }

        public List<ErrorMessage> IsEmailAddressValid(CreateContactMsgEntity createContactMsgEntity)
        {
            if (createContactMsgEntity.EmailAddress.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.EmailAddressIsEmpty);
            return null;
        }

    }
}