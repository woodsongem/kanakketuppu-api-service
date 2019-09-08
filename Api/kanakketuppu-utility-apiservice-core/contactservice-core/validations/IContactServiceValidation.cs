using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Validations
{
    public interface IContactServiceValidation
    {
        List<ErrorMessage> IsCreateContactMsgEntityValid(CreateContactMsgEntity createContactMsgEntity);
        List<ErrorMessage> IsCustomerNameValid(CreateContactMsgEntity createContactMsgEntity);
        List<ErrorMessage> IsEmailAddressValid(CreateContactMsgEntity createContactMsgEntity);
        List<ErrorMessage> IsMessageValid(CreateContactMsgEntity createContactMsgEntity);
        List<ErrorMessage> IsSubjectValid(CreateContactMsgEntity createContactMsgEntity);
        List<ErrorMessage> ValidCreateContact(CreateContactMsgEntity createContactMsgEntity);
    }
}