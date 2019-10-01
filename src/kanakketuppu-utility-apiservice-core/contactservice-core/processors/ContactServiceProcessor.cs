using System;
using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities;
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

        public List<ErrorMessage> ProcessorDeleteContactById(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity)
        {
            throw new NotImplementedException();
        }

        public List<ErrorMessage> CreateContact(CreateContactMsgEntity createContactMsgEntity)
        {
            try
            {
                var contactDAO = contactServiceMapper.MapContactDAO(createContactMsgEntity);
                contactServiceRepository.InsertContact(contactDAO);
                createContactMsgEntity.ContactId = contactDAO.Id;
            }
            catch (Exception ex)
            {
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.CreateContactUnExpectedError);
            }

            return null;
        }

    }
}