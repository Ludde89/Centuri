using TestConverter.Factories.DataFactories;
using TestConverter.Models;

namespace TestConverter.Handlers;

public class PhoneFamilyHandler(PhoneFactory factory) : IPersonHandler
{
    public bool CanHandle(Container container)
    {
        return container is { CurrentRule: "T", CurrentScope: Scope.Family };
    }

    public Container Handle(Container container, string[] data)
    {
        var phone = factory.Create(data);
        container.CurrentFamily.Phone = phone;

        return container;
    }
}