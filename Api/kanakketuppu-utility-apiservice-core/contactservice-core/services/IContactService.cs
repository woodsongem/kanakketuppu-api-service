using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Services
{
    public interface IContactService
    {
        Result CreateContact(CreateContactMsgEntity createContactMsgEntity);
         
    }
}