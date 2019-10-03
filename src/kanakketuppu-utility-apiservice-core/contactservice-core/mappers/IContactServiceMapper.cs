using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.DAOs;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Mappers
{
    public interface IContactServiceMapper
    {
        ContactDAO MapContactDAO(CreateContactMsgEntity createContactMsgEntity);

        ContactDAO MapContactDAO(DeleteContactByIdMsgEntity deleteContactByIdMsgEntity);
    }
}