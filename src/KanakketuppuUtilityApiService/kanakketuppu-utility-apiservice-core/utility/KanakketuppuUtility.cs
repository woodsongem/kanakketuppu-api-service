using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;
using KanakketuppuUtilityApiServiceModel.CommonModels;

namespace KanakketuppuUtilityApiServiceCore.Utility
{
    public class KanakketuppuUtility
    {
        public static ErrorMessage GetErrorMessage(string errorCode = null, string message = null)
        {
            return new ErrorMessage()
            {
                Message = message,
                ErrorCode = errorCode
            };
        }

        public static List<ErrorMessage> GetErrorMessages(string errorCode = null, string message = null)
        {
            return new List<ErrorMessage>(){
                GetErrorMessage(errorCode,message)
            };
        }

        public static ApiErrorMessage GetApiErrorMessage(string errorCode = null)
        {
            return new ApiErrorMessage()
            {
                ErrorCode = errorCode
            };
        }

        public static List<ApiErrorMessage> GetApiErrorMessages(string errorCode = null)
        {
            return new List<ApiErrorMessage>(){
                GetApiErrorMessage(errorCode)
            };
        }
    }
}