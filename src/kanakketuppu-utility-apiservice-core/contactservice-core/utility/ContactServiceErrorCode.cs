using Microsoft.AspNetCore.Http;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility
{
    public class ContactServiceErrorCode : IContactServiceErrorCode
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public ContactServiceErrorCode(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public string DeleteContactByIdIdNotFound => $"Kanakketuppu.Api.Post.DeleteContactById.Id.NotFound";

        public string ContactIdIsInValid => $"Kanakketuppu.Api.Post.DeleteContactMsgEntity.InValid";

        public string ContactIdIsEmpty => $"Kanakketuppu.Api.Post.DeleteContactMsgEntity.IsEmpty";

        public string DeleteContactByIdMsgEntityIsEmpty => $"Kanakketuppu.Api.Post.DeleteContactMsgEntity.IsEmpty";

        public string CreateContactMsgEntityIsEmpty => $"Kanakketuppu.Api.Post.CreateContactMsgEntity.IsEmpty";

        public string CustomerNameIsEmpty => $"Kanakketuppu.Api.Post.CustomerName.IsEmpty";

        public string SubjectIsEmpty => $"Kanakketuppu.Api.Post.Subject.IsEmpty";

        public string MessageIsEmpty => $"Kanakketuppu.Api.Post.Message.IsEmpty";

        public string EmailAddressIsEmpty => $"Kanakketuppu.Api.Post.EmailAddress.IsEmpty";

        public string CreateContactUnExpectedError => $"Kanakketuppu.Api.Post.CreateContact.UnExpectedError";

        public string InternalError => $"Kanakketuppu.Api.Post.InternalError";

        public string DeleteContactByIdAlreadyDeleted => $"Kanakketuppu.Api.DeleteContactById.AlreadyDeleted";

        public string ToManyContactsForId => $"Kanakketuppu.Api.{GetControllerName}.{GetActionName}.DeleteContactById.AlreadyDeleted";


        public string GetActionName
        {
            get
            {
                return "";
            }
        }

        public string GetControllerName
        {
            get
            {
                return httpContextAccessor.HttpContext.Items[""].ToString();
            }
        }
    }
}