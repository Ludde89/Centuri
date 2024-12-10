using TestConverter.Models;

namespace TestConverter.Factories.DataFactories;

public class FamilyAddressFactory : PeopleFactoryBase<Family>
{
    public override IDictionary<int, Action<Family, string>> GetActions()
    {
        return new Dictionary<int, Action<Family, string>>
        {
            { 1, (family, val) => family.Address.Street = val },
            { 2, (family, val) => family.Address.City = val },
            { 2, (family, val) => family.Address.Zip = val },
        };
    }
}