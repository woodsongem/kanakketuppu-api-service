using System.Collections.Generic;

namespace KanakketuppuUtilityApiServiceCore.DataContracts.Daos
{
    public class Result
    {
        public Status ResultStatus { get; set; }
        public List<ErrorMessage> ErrorMessages { get; set; }
    }
}