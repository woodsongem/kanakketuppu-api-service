using System;
using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceCore.Utility;
using KatavuccolCommon.Extensions;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Validations
{
    public class ContactServiceValidation : IContactServiceValidation
    {
        private readonly IContactServiceErrorCode contactServiceErrorCode;

        public ContactServiceValidation(IContactServiceErrorCode contactServiceErrorCode)
        {
            this.contactServiceErrorCode = contactServiceErrorCode;
        }

        public List<ErrorMessage> ValidCreateContact(CreateContactMsgEntity createContactMsgEntity)
        {
            var errorMessages = IsCreateContactMsgEntityValid(createContactMsgEntity);
            errorMessages = IsCustomerNameValid(createContactMsgEntity);
            errorMessages = IsSubjectValid(createContactMsgEntity);
            errorMessages = IsMessageValid(createContactMsgEntity);
            errorMessages = IsEmailAddressValid(createContactMsgEntity);
            return errorMessages;
        }

        public List<ErrorMessage> ValidDeleteContactById(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity)
        {
            var errorMessages = IsDeleteContactByIdMsgEntityValid(deleteContactByIdMsgEntity);
            errorMessages = IsContactIdValid(deleteContactByIdMsgEntity);
            return errorMessages;
        }

        public List<ErrorMessage> IsContactIdValid(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity)
        {
            if(deleteContactByIdMsgEntity.Id.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(contactServiceErrorCode.ContactIdIsEmpty);

            deleteContactByIdMsgEntity.ParsedId = deleteContactByIdMsgEntity.Id.ToLong();
            if (deleteContactByIdMsgEntity.ParsedId == 0)
                return KanakketuppuUtility.GetErrorMessages(contactServiceErrorCode.ContactIdIsInValid);

            return null;
        }

        public List<ErrorMessage> IsDeleteContactByIdMsgEntityValid(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity)
        {
            if (deleteContactByIdMsgEntity.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(contactServiceErrorCode.DeleteContactByIdMsgEntityIsEmpty);
            return null;
        }

        public List<ErrorMessage> IsCreateContactMsgEntityValid(CreateContactMsgEntity createContactMsgEntity)
        {
            if (createContactMsgEntity.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(contactServiceErrorCode.CreateContactMsgEntityIsEmpty);
            return null;
        }

        public List<ErrorMessage> IsCustomerNameValid(CreateContactMsgEntity createContactMsgEntity)
        {
            if (createContactMsgEntity.CustomerName.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(contactServiceErrorCode.CustomerNameIsEmpty);

            return null;
        }

        public List<ErrorMessage> IsSubjectValid(CreateContactMsgEntity createContactMsgEntity)
        {
            if (createContactMsgEntity.Subject.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(contactServiceErrorCode.SubjectIsEmpty);
            return null;
        }

        public List<ErrorMessage> IsMessageValid(CreateContactMsgEntity createContactMsgEntity)
        {
            if (createContactMsgEntity.Message.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(contactServiceErrorCode.MessageIsEmpty);
            return null;
        }

        public List<ErrorMessage> IsEmailAddressValid(CreateContactMsgEntity createContactMsgEntity)
        {
            if (createContactMsgEntity.EmailAddress.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(contactServiceErrorCode.EmailAddressIsEmpty);
            return null;
        }

    }
}