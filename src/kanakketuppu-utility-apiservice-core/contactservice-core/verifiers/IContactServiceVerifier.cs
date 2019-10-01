using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Verifiers
{
    public interface IContactServiceVerifier
    {
        List<ErrorMessage> IsContactIdValid(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity);

        List<ErrorMessage> VerifyCreateContact(CreateContactMsgEntity createContactMsgEntity);

        List<ErrorMessage> VerifyDeleteContactById(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity);
    }
}