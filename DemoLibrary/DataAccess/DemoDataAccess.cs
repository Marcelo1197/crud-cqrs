using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess: IDataAccess
    {
        private List<PersonsModel> persons = new();

        public DemoDataAccess()
        {
            this.persons = new()
            {
                new PersonsModel
                {
                    Id = 1,
                    Name = "Marcelo",
                    LastName = "Sanchez"
                },
                new PersonsModel
                {
                    Id = 2,
                    Name = "Julio",
                    LastName = "Sanchez"
                }
            };
        }

        public List<PersonsModel> getPersonList()
        {
            return persons;
        }

        public PersonsModel addPerson(PersonsModel person)
        {
            this.persons.Add(person);
            return person;
        }

        public PersonsModel Get(int id)
        {
            return this.persons.FirstOrDefault(p => p.Id == id);
        }
    }
}
