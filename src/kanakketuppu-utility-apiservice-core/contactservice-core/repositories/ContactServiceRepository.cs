using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using Dapper;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.DAOs;
using KanakketuppuUtilityApiServiceModel.ContactApiServiceModels.Contact.GetContact;
using System.Collections.Generic;
using System.Linq;
using KatavuccolCommon.Extensions;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories
{
    public class ContactServiceRepository : IContactServiceRepository
    {
        private const string KanakketuppuConnectionString = "ConnectionStrings:Kanakketuppu";
        private string connectionString;

        public ContactServiceRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetValue<string>(KanakketuppuConnectionString);
        }

        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(connectionString);
            }
        }

        public ContactDAO GetContactById(long parsedId)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var name = dbConnection.State;
                return dbConnection.Query<ContactDAO>(ContactServiceDBQueries.GetContactByIdDBQuery, new { id = parsedId })?.Single();
            }
        }

        public ContactModel GetContactModel(long contactId)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var name = dbConnection.State;
                var contactsModel = dbConnection.Query<ContactModel>(ContactServiceDBQueries.GetContactModelByIdDBQuery, new { id = contactId });
                if (contactsModel.AnyWithNullCheck())
                    return contactsModel.SingleOrDefault();
                return null;
            }
        }

        public IEnumerable<ContactModel> GetContactsModel()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var name = dbConnection.State;
                return dbConnection.Query<ContactModel>(ContactServiceDBQueries.GetContactsModelDBQuery);
            }
        }

        public void InsertContact(ContactDAO contactDAO)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var name = dbConnection.State;
                contactDAO.Id = dbConnection.Query<long>(ContactServiceDBQueries.CreateContactDBQuery, contactDAO).Single();
            }
        }
    }
}