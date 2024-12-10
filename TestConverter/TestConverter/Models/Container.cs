namespace TestConverter.Models;

public class Container
{
    public PeopleContainer People { get; set; } = new PeopleContainer();
    public string CurrentRule { get; set; }
    public string? PreviousRule { get; set; } = null;
    public Person CurrentPerson { get; set; } = new Person();
    public Family? CurrentFamily { get; set; } = null;
    public Scope CurrentScope { get; set; } = Scope.Any;
}