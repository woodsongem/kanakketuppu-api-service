using System.Collections.Generic;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

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
    }
}