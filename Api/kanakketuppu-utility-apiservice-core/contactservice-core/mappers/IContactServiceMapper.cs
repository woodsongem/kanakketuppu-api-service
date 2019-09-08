using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.DAOs;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Mappers
{
    public interface IContactServiceMapper
    {
        ContactDAO MapContactDAO(CreateContactMsgEntity createContactMsgEntity);
    }
}