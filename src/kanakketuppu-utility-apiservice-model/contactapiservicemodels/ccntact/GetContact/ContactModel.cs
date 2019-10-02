using System;

namespace KanakketuppuUtilityApiServiceModel.ContactApiServiceModels.Contact.GetContact
{
    public class ContactModel
    {
        public long id { get; set; }

        public string customername { get; set; }

        public string subject { get; set; }

        public string message { get; set; }

        public string emailaddress { get; set; }

        public string status { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public bool IsActive { get; set; }
    }
}
