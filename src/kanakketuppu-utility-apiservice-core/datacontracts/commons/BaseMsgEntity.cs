using System;
using System.Net;

namespace KanakketuppuUtilityApiServiceCore.DataContracts.Commons
{
    public class BaseMsgEntity
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public bool IsActive { get; set; }

        public HttpStatusCode? HttpStatusCode { set; get; }
    }
}