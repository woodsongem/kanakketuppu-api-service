using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.DAOs;
using KanakketuppuUtilityApiServiceCore.DataContracts.Daos;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories
{
    public interface IContactServiceRepository
    {
        OutputResult InsertContact(ContactDAO contactDAO);
    }
}