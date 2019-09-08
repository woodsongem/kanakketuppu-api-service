using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Mappers;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

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
            throw new System.NotImplementedException();
        }

        public List<ErrorMessage> CreateContact(CreateContactMsgEntity createContactMsgEntity)
        {
            var contactDAO = contactServiceMapper.MapContactDAO(createContactMsgEntity);
            var outputResult = contactServiceRepository.InsertContact(contactDAO);
            return null;
        }
    }
}