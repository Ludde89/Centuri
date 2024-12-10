using TestConverter.Models;

namespace TestConverter.Factories.DataFactories;

public class FamilyPhoneFactory : PeopleFactoryBase<Family>
{
    public override IDictionary<int, Action<Family, string>> GetActions()
    {
        return new Dictionary<int, Action<Family, string>>
        {
            { 1, (family, val) => family.Phone.Mobil = val },
            { 2, (family, val) => family.Phone.LandLine = val }
        };
    }
}