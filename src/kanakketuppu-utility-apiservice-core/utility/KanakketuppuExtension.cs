using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceModel.CommonModels;
using KatavuccolCommon.Extensions;

namespace KanakketuppuUtilityApiServiceCore.Utility
{
    public static class KanakketuppuExtension
    {
   
        public static List<ApiErrorMessage> ToApiErrorMessageWithInternalError(this List<ErrorMessage> errorMessages)
        {
            return ToApiErrorMessage(errorMessages);
        }

        public static List<ApiErrorMessage> ToApiErrorMessage(this List<ErrorMessage> errorMessages)
        {
            if (!errorMessages.AnyWithNullCheck())
                return null;
            var apiErrorMessages = new List<ApiErrorMessage>();
            foreach (var errorMessage in errorMessages)
            {
                apiErrorMessages.Add(new ApiErrorMessage
                {
                    ErrorCode = errorMessage.ErrorCode
                });
            }
            return apiErrorMessages;
        }
    }
}