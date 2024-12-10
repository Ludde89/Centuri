using TestConverter.Factories.DataFactories;
using TestConverter.Models;

namespace TestConverter.Handlers;

public class AddressHandler(AddressFactory factory) : IPersonHandler
{
    public bool CanHandle(Container container)
    {
        return container.CurrentRule == "A" && container.CurrentScope == Scope.Person;
    }

    public Container Handle(Container container, string[] data)
    {
        var address = factory.Create(data);
        container.CurrentPerson.Address = address;

        return container;
    }
}