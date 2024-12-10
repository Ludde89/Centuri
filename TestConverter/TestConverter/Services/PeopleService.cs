using TestConverter.Handlers;
using TestConverter.Models;

namespace TestConverter.Services;

public class PeopleService(IEnumerable<IPersonHandler> handlers)
{
    private readonly IDictionary<string, HashSet<string>> _rules = new Dictionary<string, HashSet<string>>()
    {
        { "P", ["T", "A", "F"] },
        { "T", ["A", "F"] },
        { "A", ["T", "F"] },
        { "F", ["T", "A"] }
    };

    public PeopleContainer Parse(IEnumerable<string> data)
    {
        var container = new Container();

        data
            .Select(s => s.Split('|'))
            .ToList()
            .ForEach(s =>
            {

                if (!_rules.TryGetValue(s[0], out var _))
                {
                    //TODO: Implement logging and handle unsupported data
                    return;
                }
                container.CurrentRule = s[0];

                if (AddNewPerson(container.PreviousRule, container.CurrentRule))
                {
                    container.CurrentPerson?.Family.Add(container.CurrentFamily ?? new Family());
                    container.CurrentFamily = null;
                    container.People.People.Add(container.CurrentPerson ?? new Person());
                }

                container = handlers.FirstOrDefault(y => y.CanHandle(container))?.Handle(container, s) ?? throw new NotImplementedException();
                container.PreviousRule = container.CurrentRule;
            });

        Save(container);

        return container.People;
    }

    private static void Save(Container container)
    {
        if (container.CurrentFamily != null)
        {
            container.CurrentPerson.Family.Add(container.CurrentFamily ?? new Family());
        }

        container.People.People.Add(container.CurrentPerson);
    }

    private bool AddNewPerson(string? lastRule, string rule)
    {
        return !string.IsNullOrWhiteSpace(lastRule) && !_rules[lastRule].Contains(rule);
    }
}