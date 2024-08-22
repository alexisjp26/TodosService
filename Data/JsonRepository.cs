
using System.Text.Json;

namespace TodosService.Data
{
    public class JsonRepository<T> : IRepository<T> where T : class
    {
        private readonly List<T> _tasks;

        public JsonRepository()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            using (StreamReader reader = new StreamReader("Data\\todos.json"))
            {
                string json = reader.ReadToEnd();
                var source = JsonSerializer.Deserialize<List<T>>(json, options);
                _tasks = source ?? new List<T>();
            }
        }
        public IEnumerable<T> GetAll()
        {
            return _tasks;
        }
    }
}