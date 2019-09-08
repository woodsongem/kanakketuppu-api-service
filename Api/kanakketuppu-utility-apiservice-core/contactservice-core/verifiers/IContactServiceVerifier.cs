using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Verifiers
{
    public interface IContactServiceVerifier
    {
        List<ErrorMessage> VerifyCreateContact(CreateContactMsgEntity createContactMsgEntity);
    }
}