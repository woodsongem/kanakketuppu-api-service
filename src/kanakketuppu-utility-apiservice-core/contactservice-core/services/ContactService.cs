using System;
using System.Linq;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Mappers;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.PostProcessors;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Processors;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Validations;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Verifiers;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceCore.Utility;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactServiceValidation contactServiceValidation;
        private readonly IContactServiceVerifier contactServiceVerifier;
        private readonly IContactServiceProcessor contactServiceProcessor;
        private readonly IContactServicePostProcessor contactServicePostProcessor;
        private readonly IContactServiceMapper contactServiceMapper;

        public ContactService(
            IContactServiceValidation contactServiceValidation,
            IContactServiceVerifier contactServiceVerifier,
            IContactServiceProcessor contactServiceProcessor,
            IContactServicePostProcessor contactServicePostProcessor,
            IContactServiceMapper contactServiceMapper)
        {
            this.contactServiceValidation = contactServiceValidation;
            this.contactServiceVerifier = contactServiceVerifier;
            this.contactServiceProcessor = contactServiceProcessor;
            this.contactServicePostProcessor = contactServicePostProcessor;
            this.contactServiceMapper = contactServiceMapper;
        }

        public Result CreateContact(CreateContactMsgEntity createContactMsgEntity)
        {
            //Setup
            createContactMsgEntity.CreatedOn = createContactMsgEntity.ModifiedOn = DateTime.UtcNow;
            createContactMsgEntity.CreatedBy = createContactMsgEntity.ModifiedBy = "ADMIN";

            //Validation
            var resultMessage = contactServiceValidation.ValidCreateContact(createContactMsgEntity);

            //Verifier
            resultMessage = contactServiceVerifier.VerifyCreateContact(createContactMsgEntity);

            //Processor
            resultMessage = contactServiceProcessor.ProcessorCreateContact(createContactMsgEntity);

            //PostProcessor
            var postResultMessage = contactServicePostProcessor.PostProcessorCreateContact(createContactMsgEntity);

            return new Result() { ResultStatus = resultMessage.ToStatus(), ErrorMessages = resultMessage };
        }
    }
}