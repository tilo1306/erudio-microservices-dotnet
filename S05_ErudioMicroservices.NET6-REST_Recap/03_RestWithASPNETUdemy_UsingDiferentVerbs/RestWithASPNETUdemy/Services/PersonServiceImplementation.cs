using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Services.Implementations;

namespace RestWithASPNETUdemy.Services
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
           
        }

        public List<Person> FindaAll()
        {
            List<Person> persons = new();

            for (int i = 0; i <8;i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

       

        public Person FindByID(long id)
        {
            return new Person 
            { 
                Id = IncrementAndGet(),
                FirstName = "Person Name",
                LastName = "Person LastName",
                Address = "Some Address",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;  
        }


        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
