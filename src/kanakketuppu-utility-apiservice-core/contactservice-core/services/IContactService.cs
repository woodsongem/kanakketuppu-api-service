using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels.Contact.GetContact;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Services
{
    public interface IContactService
    {
        List<ErrorMessage> CreateContact(CreateContactMsgEntity createContactMsgEntity);

        IEnumerable<ContactModel> GetContactsModel();

        ContactModel GetContactModel(string id);
    }
}