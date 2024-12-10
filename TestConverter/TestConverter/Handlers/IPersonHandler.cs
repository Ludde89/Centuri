using TestConverter.Models;

namespace TestConverter.Handlers;

public interface IPersonHandler
{
    bool CanHandle(Container container);
    Container Handle(Container container, string[] data);
}

public class DefaultHandler : IPersonHandler
{
    public bool CanHandle(Container container) => true;

    public Container Handle(Container container, string[] data)
    {
        //TODO: Implement logger and handling for unsupported data types

        return container;
    }
}