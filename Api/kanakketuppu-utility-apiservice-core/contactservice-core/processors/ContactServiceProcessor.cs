using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Mappers;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceCore.Utility;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Processors
{
    public class ContactServiceProcessor : IContactServiceProcessor
    {
        private readonly IContactServiceRepository contactServiceRepository;
        private readonly IContactServiceMapper contactServiceMapper;

        public ContactServiceProcessor(
            IContactServiceRepository contactServiceRepository,
            IContactServiceMapper contactServiceMapper)
        {
            this.contactServiceRepository = contactServiceRepository;
            this.contactServiceMapper = contactServiceMapper;
        }

        public List<ErrorMessage> ProcessorCreateContact(CreateContactMsgEntity createContactMsgEntity)
        {
            var errorMessages = CreateContact(createContactMsgEntity);
            return errorMessages;
        }

        public List<ErrorMessage> CreateContact(CreateContactMsgEntity createContactMsgEntity)
        {
            var contactDAO = contactServiceMapper.MapContactDAO(createContactMsgEntity);
            var outputResult = contactServiceRepository.InsertContact(contactDAO);
            if (outputResult.IsEmpty() || outputResult.ErrorMessages.AnyWithNullCheck())
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.CreateContactUnExpectedError);
            createContactMsgEntity.ContactId = outputResult.Key.ToLong();
            return null;
        }
    }
}