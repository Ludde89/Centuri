namespace TestConverter.Repositories;

public class PeopleRepository
{
    public IEnumerable<string> Get()
    {
        var list = new List<string>();
        StreamReader sr = new StreamReader("source.txt");
        var line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            list.Add(line);
            line = sr.ReadLine();
        }

        return list;
    }
}