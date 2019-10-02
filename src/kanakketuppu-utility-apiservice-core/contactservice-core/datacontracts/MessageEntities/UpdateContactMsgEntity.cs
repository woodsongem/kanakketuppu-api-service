using System;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.MessageEntities
{
    public class UpdateContactMsgEntity : BaseMsgEntity
    {
        public string Id { get; set; }

        public string CustomerName { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public string EmailAddress { get; set; }
    }
}
