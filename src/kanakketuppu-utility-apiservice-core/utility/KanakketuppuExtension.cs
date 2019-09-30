using System.Linq;
using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceModel.CommonModels;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility;
using KatavuccolCommon.Extensions;

namespace KanakketuppuUtilityApiServiceCore.Utility
{
    public static class KanakketuppuExtension
    {
        public static List<ApiErrorMessage> ToApiErrorMessageWithInternalError(this List<ErrorMessage> errorMessages)
        {
            var apiErrorMessages = ToApiErrorMessage(errorMessages);
            if (apiErrorMessages.AnyWithNullCheck())
            {
                return KanakketuppuUtility.GetApiErrorMessages(ContactServiceErrorCode.InternalError);
            }

            return apiErrorMessages;
        }
        public static List<ApiErrorMessage> ToApiErrorMessage(this List<ErrorMessage> errorMessages)
        {
            if (!errorMessages.AnyWithNullCheck())
                return null;
            var apiErrorMessages = new List<ApiErrorMessage>();
            foreach (var errorMessage in errorMessages)
            {
                apiErrorMessages.Add(new ApiErrorMessage()
                {
                    ErrorCode = errorMessage.ErrorCode
                });
            }
            return apiErrorMessages;
        }
    }
}