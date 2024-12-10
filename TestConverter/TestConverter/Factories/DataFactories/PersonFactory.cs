using TestConverter.Models;

namespace TestConverter.Factories.DataFactories;

public class PersonFactory : PeopleFactoryBase<Person>
{
    public override IDictionary<int, Action<Person, string>> GetActions()
    {
        return new Dictionary<int, Action<Person, string>>
        {
            { 1, (person, val) => person.FirstName = val },
            { 2, (person, val) => person.LastName = val }
        };
    }
}