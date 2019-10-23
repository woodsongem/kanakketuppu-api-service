using System.Collections.Generic;
using System.Linq;
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
        private readonly IContactServiceErrorCode contactServiceErrorCode;

        public ContactServiceVerifier(
            IContactServiceRepository contactServiceRepository,
            IContactServiceErrorCode contactServiceErrorCode)
        {
            this.contactServiceRepository = contactServiceRepository;
            this.contactServiceErrorCode = contactServiceErrorCode;
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
            if (!contactDao.AnyWithNullCheck())
            {
                deleteContactByIdMsgEntity.HttpStatusCode = HttpStatusCode.NotFound;
                return KanakketuppuUtility.GetErrorMessages(contactServiceErrorCode.DeleteContactByIdIdNotFound);
            }

            deleteContactByIdMsgEntity.ExistingContact = contactDao;
            return null;
        }

        public List<ErrorMessage> IsContactIsReadyToDelete(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity)
        {
            if (deleteContactByIdMsgEntity.ExistingContact.Count() >= 2)
            {
                return KanakketuppuUtility.GetErrorMessages(contactServiceErrorCode.ToManyContactsForId);
            }
            if (deleteContactByIdMsgEntity.ExistingContact.FirstOrDefault().Status.IsEqual(ContactStatus.DELETED.ToString()))
            {
                return KanakketuppuUtility.GetErrorMessages(contactServiceErrorCode.DeleteContactByIdAlreadyDeleted);
            }

            return null;
        }
    }
}