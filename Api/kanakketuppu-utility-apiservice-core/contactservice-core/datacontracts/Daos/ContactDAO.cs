using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.DAOs
{
    public class ContactDAO : BaseDao
    {
        public string CustomerName { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string EmailAddress { get; set; }
    }
}