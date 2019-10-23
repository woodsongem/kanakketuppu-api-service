using System;
namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Utility
{
    public interface IContactServiceErrorCode
    {
        string DeleteContactByIdIdNotFound { get; }

        string ContactIdIsInValid { get; }

        string ContactIdIsEmpty { get; }

        string DeleteContactByIdMsgEntityIsEmpty { get; }

        string CreateContactMsgEntityIsEmpty { get; }

        string CustomerNameIsEmpty { get; }

        string SubjectIsEmpty { get; }

        string MessageIsEmpty { get; }

        string EmailAddressIsEmpty { get; }

        string CreateContactUnExpectedError { get; }

        string InternalError { get; }

        string DeleteContactByIdAlreadyDeleted { get; }

        string ToManyContactsForId { get; }
    }
}
