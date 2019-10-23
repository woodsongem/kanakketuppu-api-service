namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories
{
    public static class ContactServiceDBQueries
    {
        public const string GetContactsModelDBQuery = "SELECT id, customername, subject, emailaddress, message, status, createdby, createdon, modifiedby, modifiedon, isactive FROM public.contactqueries where isactive=true;";

        public const string GetContactModelByIdDBQuery = "SELECT id, customername, subject, emailaddress, message, status, createdby, createdon, modifiedby, modifiedon, isactive FROM public.contactqueries where isactive=true and id=@id";

        public const string CreateContactDBQuery = "INSERT INTO public.contactqueries (customername, subject, emailaddress, message, status, createdby, createdon, modifiedby, modifiedon, isactive) VALUES (@CustomerName,@Subject,@EmailAddress,@Message,'NEW','ADMIN', @CreatedOn, 'ADMIN', @ModifiedOn, true) RETURNING Id";

        public const string GetContactByIdDBQuery = "SELECT id, customername, subject, emailaddress, message, status, createdby, createdon, modifiedby, modifiedon, isactive FROM public.contactqueries where isactive=true and id=@id";

        public const string DeleteContactByIdDBQuery = "UPDATE public.contactqueries SET status ='DELETED' , modifiedby =@modifiedby, modifiedon =@modifiedon, isactive =false WHERE id=@id;";
    }
}
