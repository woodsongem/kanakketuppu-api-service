using System;
using KanakketuppuUtilityApiServiceModel.CommonModels;

namespace KanakketuppuUtilityApiServiceModel.ContactApiServiceModels.Contact.UpdateContact
{
    public class UpdateContactApiModel : BaseApiModel
    {
        public string CustomerName { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public string EmailAddress { get; set; }

        public string Status { get; set; }
    }
}
