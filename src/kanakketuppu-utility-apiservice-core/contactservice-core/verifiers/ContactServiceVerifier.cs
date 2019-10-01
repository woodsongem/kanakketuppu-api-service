using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

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
            return null;
        }

        public List<ErrorMessage> IsContactIdValid(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity)
        {
            var contactDao = contactServiceRepository.GetContactById(deleteContactByIdMsgEntity.ParsedId);
            return null;
        }
    }
}