using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Verifiers
{
    public class ContactServiceVerifier : IContactServiceVerifier
    {
        public List<ErrorMessage> VerifyCreateContact(CreateContactMsgEntity createContactMsgEntity)
        {
            return null;
        }
    }
}