using KanakketuppuUtilityApiServiceCore.DataContracts.Daos;
using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories.DAOs;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories
{
    public interface IContactServiceRepository
    {
        OutputResult InsertContact(ContactDAO contactDAO);
    }
}