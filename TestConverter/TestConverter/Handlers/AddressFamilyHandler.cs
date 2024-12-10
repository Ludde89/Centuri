using TestConverter.Factories.DataFactories;
using TestConverter.Models;

namespace TestConverter.Handlers;

public class AddressFamilyHandler(AddressFactory factory) : IPersonHandler
{
    public bool CanHandle(Container container)
    {
        return container.CurrentRule == "A" && container.CurrentScope == Scope.Family;
    }

    public Container Handle(Container container, string[] data)
    {
        var address = factory.Create(data);
        container.CurrentFamily.Address = address;

        return container;
    }
}