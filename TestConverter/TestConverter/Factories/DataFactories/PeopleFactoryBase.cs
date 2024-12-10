namespace TestConverter.Factories.DataFactories;

public abstract class PeopleFactoryBase<T> where T : class, new()
{
    public abstract IDictionary<int, Action<T, string>> GetActions();

    public T Create(string[] data)
    {
        var obj = new T();
        var acts = GetActions();
        for (int i = 0; i < data.Length; i++)
        {
            if (acts.TryGetValue(i, out var value))
            {
                value(obj, data[i]);
            }
        }

        return obj;
    }
}