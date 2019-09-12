using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using Dapper;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.DAOs;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

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

        public async void InsertContact(ContactDAO contactDAO)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var name = dbConnection.State;
                contactDAO.Id = await dbConnection.ExecuteScalarAsync<long>("INSERT INTO public.contactquery (" +
                                        "customername, subject, emailaddress, message, status, createdby, createdon, modifiedby, modifiedon, isactive)" +
                                        " VALUES (@CustomerName,@Subject,@EmailAddress,@Message,'NEW','ADMIN', @CreatedOn, 'ADMIN', @ModifiedOn, @IsActive) RETURNING Id", contactDAO);

            }
        }
    }
}