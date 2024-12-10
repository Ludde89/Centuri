using TestConverter.Factories.DataFactories;
using TestConverter.Models;

namespace TestConverter.Handlers;

public class PhoneHandler(PhoneFactory factory) : IPersonHandler
{
    public bool CanHandle(Container container)
    {
        return container is { CurrentRule: "T", CurrentScope: Scope.Person };
    }

    public Container Handle(Container container, string[] data)
    {
        var phone = factory.Create(data);
        container.CurrentPerson.Phone = phone;

        return container;
    }
}