using System;
using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.DAOs;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities
{
    public class DeleteContactByIdMsgEntity : BaseMsgEntity
    {
        public string Id { get; set; }

        public long ParsedId { get; set; }

        public IEnumerable<ContactDAO> ExistingContact { get; set; }
    }
}
