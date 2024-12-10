using TestConverter.Factories.DataFactories;
using TestConverter.Models;

namespace TestConverter.Handlers;

public class FamilyHandler(FamilyFactory factory) : IPersonHandler
{
    public bool CanHandle(Container container)
    {
        return container.CurrentRule == "F";
    }

    public Container Handle(Container container, string[] data)
    {
        if (container.CurrentFamily != null)
        {
            container.CurrentPerson.Family.Add(container.CurrentFamily);
        }
        container.CurrentScope = Scope.Family;

        container.CurrentFamily = factory.Create(data);

        return container;
    }
}