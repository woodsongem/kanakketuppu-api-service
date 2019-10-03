using System;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.DAOs;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities
{
    public class DeleteContactByIdMsgEntity : BaseMsgEntity
    {
        public string Id { get; set; }

        public long ParsedId { get; set; }

        public ContactDAO ExistingContact { get; set; }
    }
}
