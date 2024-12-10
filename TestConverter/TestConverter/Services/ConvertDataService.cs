using System.Text.Json;
using System.Text.Json.Serialization;
using TestConverter.Repositories;

namespace TestConverter.Services
{
    public class ConvertDataService(PeopleRepository repository, PeopleService service)
    {
        public string Run()
        {
            var data = repository.Get();
            var people = service.Parse(data);

            var serialize = JsonSerializer.Serialize(people, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault

            });

            return serialize;
        }
    }
}