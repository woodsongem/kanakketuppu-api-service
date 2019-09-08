using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.PostProcessors
{
    public class ContactServicePostProcessor : IContactServicePostProcessor
    {
        public List<ErrorMessage> PostProcessorCreateContact(CreateContactMsgEntity createContactMsgEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}