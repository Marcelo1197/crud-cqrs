using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        public List<PersonsModel> getPersonList();

        public PersonsModel addPerson(PersonsModel person);

        public PersonsModel Get(int id);

    }
}
