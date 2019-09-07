using KanakketuppuUtilityApiServiceCore.DataContracts.Daos;

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