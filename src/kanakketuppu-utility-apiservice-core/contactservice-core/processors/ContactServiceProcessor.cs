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
        private readonly IContactServiceErrorCode contactServiceErrorCode;

        public ContactServiceProcessor(
            IContactServiceRepository contactServiceRepository,
            IContactServiceMapper contactServiceMapper,
            IContactServiceErrorCode contactServiceErrorCode)
        {
            this.contactServiceRepository = contactServiceRepository;
            this.contactServiceMapper = contactServiceMapper;
            this.contactServiceErrorCode = contactServiceErrorCode;
        }

        public List<ErrorMessage> ProcessorCreateContact(CreateContactMsgEntity createContactMsgEntity)
        {
            var errorMessages = CreateContact(createContactMsgEntity);
            return errorMessages;
        }

        public List<ErrorMessage> ProcessorDeleteContactById(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity)
        {
            var errorMessages = DeleteContactById(deleteContactByIdMsgEntity);
            return errorMessages;
        }

        public List<ErrorMessage> DeleteContactById(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity)
        {
            var contactDAO = contactServiceMapper.MapContactDAO(deleteContactByIdMsgEntity);
            contactServiceRepository.DeleteContactById(contactDAO);

            return null;
        }

        public List<ErrorMessage> CreateContact(CreateContactMsgEntity createContactMsgEntity)
        {
            var contactDAO = contactServiceMapper.MapContactDAO(createContactMsgEntity);
            contactServiceRepository.InsertContact(contactDAO);
            createContactMsgEntity.ContactId = contactDAO.Id;
            if (createContactMsgEntity.ContactId <= 0)
                return KanakketuppuUtility.GetErrorMessages(contactServiceErrorCode.CreateContactUnExpectedError);

            return null;
        }

    }
}