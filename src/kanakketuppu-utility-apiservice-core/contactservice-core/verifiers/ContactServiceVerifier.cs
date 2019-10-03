using System.Collections.Generic;
using System.Net;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.DAOs;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceCore.Utility;
using KatavuccolCommon.Extensions;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Verifiers
{
    public class ContactServiceVerifier : IContactServiceVerifier
    {
        private readonly IContactServiceRepository contactServiceRepository;

        public ContactServiceVerifier(IContactServiceRepository contactServiceRepository)
        {
            this.contactServiceRepository = contactServiceRepository;
        }

        public List<ErrorMessage> VerifyCreateContact(CreateContactMsgEntity createContactMsgEntity)
        {
            return null;
        }

        public List<ErrorMessage> VerifyDeleteContactById(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity)
        {
            var errorMessages = IsContactIdValid(deleteContactByIdMsgEntity);
            if (errorMessages.AnyWithNullCheck())
                return errorMessages;
            errorMessages = IsContactIsReadyToDelete(deleteContactByIdMsgEntity);
            if (errorMessages.AnyWithNullCheck())
                return errorMessages;
            return errorMessages;
        }

        public List<ErrorMessage> IsContactIdValid(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity)
        {
            var contactDao = contactServiceRepository.GetContactById(deleteContactByIdMsgEntity.ParsedId);
            if (contactDao.IsEmpty())
            {
                deleteContactByIdMsgEntity.HttpStatusCode = HttpStatusCode.NotFound;
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.DeleteContactByIdIdNotFound);
            }

            deleteContactByIdMsgEntity.ExistingContact = contactDao;
            return null;
        }

        public List<ErrorMessage> IsContactIsReadyToDelete(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity)
        {
            if (deleteContactByIdMsgEntity.ExistingContact.Status.IsEqual(ContactStatus.DELETED.ToString()))
            {
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.DeleteContactByIdAlreadyDeleted);
            }

            return null;
        }
    }
}