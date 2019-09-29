using System.Linq;
using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceModel.CommonModels;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility;

namespace KanakketuppuUtilityApiServiceCore.Utility
{
    public static class KanakketuppuExtension
    {
        public static bool AnyWithNullCheck<TSource>(this IEnumerable<TSource> value)
        {
            if (value == null)
                return false;
            return value.Any();
        }

        public static bool IsEmpty(this object value)
        {
            return value == null;
        }

        public static bool IsEmpty(this string value)
        {
            if (value == null)
                return true;
            return string.IsNullOrWhiteSpace(value);
        }

        public static long ToLong(this string value)
        {
            if (value.IsEmpty())
                return 0;
            if (long.TryParse(value, out long result))
                return 0;
            return result;
        }

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