using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Mappers;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.PostProcessors;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Processors;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Validations;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Verifiers;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

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
            throw new System.NotImplementedException();
        }
    }
}