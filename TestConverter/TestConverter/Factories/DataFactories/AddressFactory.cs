using TestConverter.Models;

namespace TestConverter.Factories.DataFactories;

public class AddressFactory : PeopleFactoryBase<Address>
{
    public override IDictionary<int, Action<Address, string>> GetActions()
    {
        return new Dictionary<int, Action<Address, string>>
        {
            { 1, (address, val) => address.Street = val },
            { 2, (address, val) => address.City = val },
            { 3, (address, val) => address.Zip = val }
        };
    }
}