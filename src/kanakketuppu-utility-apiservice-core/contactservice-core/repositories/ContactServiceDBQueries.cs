using System;
namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories
{
    public static class ContactServiceDBQueries
    {
        public const string GetContactsModelDBQuery = "SELECT id, customername, subject, emailaddress, message, status, createdby, createdon, modifiedby, modifiedon, isactive FROM public.contactquery where isactive=true;";
    }
}
