using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Processors
{
    public class ContactServiceProcessor : IContactServiceProcessor
    {
        private readonly IContactServiceRepository contactServiceRepository;
        public ContactServiceProcessor(IContactServiceRepository contactServiceRepository)
        {
            this.contactServiceRepository = contactServiceRepository;
        }
    }
}