using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts
{
    public class CreateContactMsgEntity : BaseMsgEntity
    {
        public long ContactId { get; set; }
        public string CustomerName { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string EmailAddress { get; set; }
    }
}