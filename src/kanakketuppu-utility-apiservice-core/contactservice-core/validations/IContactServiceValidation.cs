using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Validations
{
    public interface IContactServiceValidation
    {
        List<ErrorMessage> ValidCreateContact(CreateContactMsgEntity createContactMsgEntity);

        List<ErrorMessage> ValidDeleteContactById(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity);

        List<ErrorMessage> IsCreateContactMsgEntityValid(CreateContactMsgEntity createContactMsgEntity);

        List<ErrorMessage> IsCustomerNameValid(CreateContactMsgEntity createContactMsgEntity);

        List<ErrorMessage> IsEmailAddressValid(CreateContactMsgEntity createContactMsgEntity);

        List<ErrorMessage> IsMessageValid(CreateContactMsgEntity createContactMsgEntity);

        List<ErrorMessage> IsSubjectValid(CreateContactMsgEntity createContactMsgEntity);

        List<ErrorMessage> IsDeleteContactByIdMsgEntityValid(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity);
        List<ErrorMessage> IsContactIdValid(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity);
    }
}