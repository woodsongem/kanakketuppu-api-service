using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.DAOs;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Mappers
{
    public class ContactServiceMapper : IContactServiceMapper
    {
        public ContactDAO MapContactDAO(CreateContactMsgEntity createContactMsgEntity)
        {
            return new ContactDAO()
            {
                EmailAddress = createContactMsgEntity.EmailAddress,
                CustomerName = createContactMsgEntity.CustomerName,
                Message = createContactMsgEntity.Message,
                Subject = createContactMsgEntity.Subject,
                IsActive = createContactMsgEntity.IsActive,
                CreatedBy = createContactMsgEntity.CreatedBy,
                CreatedOn = createContactMsgEntity.CreatedOn,
                ModifiedBy = createContactMsgEntity.ModifiedBy,
                ModifiedOn = createContactMsgEntity.ModifiedOn
            };
        }
    }
}