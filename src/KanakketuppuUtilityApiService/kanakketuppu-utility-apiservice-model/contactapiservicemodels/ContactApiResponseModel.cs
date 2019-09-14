using System.Collections.Generic;
using KanakketuppuUtilityApiServiceModel.CommonModels;

namespace KanakketuppuUtilityApiServiceModel.ContactApiServiceModels
{
    public class ContactApiResponseModel
    {
        public long Id { get; set; }

        public List<ApiErrorMessage> ErrorMessages { get; set; }
    }
}