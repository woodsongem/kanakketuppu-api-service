namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility
{
    public static class ContactServiceErrorCode
    {
        public const string DeleteContactByIdIdNotFound = "Kanakketuppu.Api.Post.DeleteContactById.Id.NotFound";

        public const string ContactIdIsInValid = "Kanakketuppu.Api.Post.DeleteContactMsgEntity.InValid";

        public const string ContactIdIsEmpty = "Kanakketuppu.Api.Post.DeleteContactMsgEntity.IsEmpty";

        public const string DeleteContactByIdMsgEntityIsEmpty = "Kanakketuppu.Api.Post.DeleteContactMsgEntity.IsEmpty";

        public const string CreateContactMsgEntityIsEmpty = "Kanakketuppu.Api.Post.CreateContactMsgEntity.IsEmpty";

        public const string CustomerNameIsEmpty = "Kanakketuppu.Api.Post.CustomerName.IsEmpty";

        public const string SubjectIsEmpty = "Kanakketuppu.Api.Post.Subject.IsEmpty";

        public const string MessageIsEmpty = "Kanakketuppu.Api.Post.Message.IsEmpty";

        public const string EmailAddressIsEmpty = "Kanakketuppu.Api.Post.EmailAddress.IsEmpty";

        public const string CreateContactUnExpectedError = "Kanakketuppu.Api.Post.CreateContact.UnExpectedError";

        public const string InternalError = "Kanakketuppu.Api.Post.InternalError";

        public const string DeleteContactByIdAlreadyDeleted = "Kanakketuppu.Api.DeleteContactById.AlreadyDeleted";
    }
}