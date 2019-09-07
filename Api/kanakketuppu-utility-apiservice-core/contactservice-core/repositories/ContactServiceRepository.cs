using KanakketuppuUtilityApiServiceCore.DataContracts.Daos;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using Dapper;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.DAOs;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories
{
    public class ContactServiceRepository : IContactServiceRepository
    {
        private const string V = "DBInfo:ConnectionString";
        private string connectionString;

        public ContactServiceRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetValue<string>(V);
        }

        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(connectionString);
            }
        }

        public OutputResult InsertContact(ContactDAO contactDAO)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("INSERT INTO public.contactquery(" +
                                    "customername, subject, emailaddress, message, status, createdby, createdon, modifiedby, modifiedon, isactive)" +
                                    "VALUES (@CustomerName,@Subject,@EmailAddress,@Message,'','ADMIN', @CreatedOn, 'ADMIN', @ModifiedOn, 1)", contactDAO);
            }
            return null;
        }
    }
}