using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Processors
{
    public interface IContactServiceProcessor
    {
        List<ErrorMessage> CreateContact(CreateContactMsgEntity createContactMsgEntity);
        List<ErrorMessage> DeleteContactById(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity);
        List<ErrorMessage> ProcessorCreateContact(CreateContactMsgEntity createContactMsgEntity);

        List<ErrorMessage> ProcessorDeleteContactById(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity);
    }
}