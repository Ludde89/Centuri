namespace TestConverter.Models;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address Address { get; set; }
    public Phone Phone { get; set; }
    public IList<Family> Family { get; set; } = new List<Family>();
}