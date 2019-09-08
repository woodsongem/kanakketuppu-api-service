using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Processors
{
    public interface IContactServiceProcessor
    {
        List<ErrorMessage> ProcessorCreateContact(CreateContactMsgEntity createContactMsgEntity);
    }
}