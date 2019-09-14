using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceCore.Utility;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility
{
    public static class ContactServiceExtension
    {
        public static Status ToStatus(this List<ErrorMessage> value)
        {
            if (value.AnyWithNullCheck())
                return Status.Fail;
            return Status.Success;
        }
    }
}