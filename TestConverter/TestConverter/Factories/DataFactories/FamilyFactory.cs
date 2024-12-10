using TestConverter.Models;

namespace TestConverter.Factories.DataFactories;

public class FamilyFactory : PeopleFactoryBase<Family>
{
    public override IDictionary<int, Action<Family, string>> GetActions()
    {
        return new Dictionary<int, Action<Family, string>>
        {
            { 1, (family, val) => family.Name = val },
            { 2, (family, val) => family.Born = val }
        };
    }
}