using TestConverter.Factories.DataFactories;
using TestConverter.Models;

namespace TestConverter.Handlers;

public class PersonHandler(PersonFactory factory) : IPersonHandler
{
    public bool CanHandle(Container container)
    {
        return container.CurrentRule == "P";
    }

    public Container Handle(Container container, string[] data)
    {
        container.CurrentPerson = new Person();
        container.CurrentScope = Scope.Person;

        var person = factory.Create(data);

        container.CurrentPerson = person;

        return container;
    }
}