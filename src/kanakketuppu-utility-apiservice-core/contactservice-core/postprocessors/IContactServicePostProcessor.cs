using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.PostProcessors
{
    public interface IContactServicePostProcessor
    {
        List<ErrorMessage> PostProcessorCreateContact(CreateContactMsgEntity createContactMsgEntity);

        List<ErrorMessage> PostProcessorDeleteContactById(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity);
    }
}