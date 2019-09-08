using KanakketuppuUtilityApiServiceCore.ContactServiceCore.Datacontracts.DAOs;
using KanakketuppuUtilityApiServiceCore.DataContracts.Commons;

namespace KanakketuppuUtilityApiServiceCore.ContactServiceCore.Repositories
{
    public interface IContactServiceRepository
    {
        OutputResult InsertContact(ContactDAO contactDAO);
    }
}