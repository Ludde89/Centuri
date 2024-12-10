using TestConverter.Models;

namespace TestConverter.Factories.DataFactories;

public class PhoneFactory : PeopleFactoryBase<Phone>
{
    public override IDictionary<int, Action<Phone, string>> GetActions()
    {
        return new Dictionary<int, Action<Phone, string>>
        {
            { 1, (phone, val) => phone.Mobil = val },
            { 2, (phone, val) => phone.LandLine = val }
        };
    }
}