using System.Text.Json;
using JsonFake.Lib.Models;

namespace JsonFake.Lib;

public class UserAPI
{
    private readonly HttpClient _http;

    public UserAPI()
    {
        _http = new HttpClient()
        {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com")
        };
    }
    
    public User? GetUserById(int id)
    {
        var response = _http.GetAsync($"users?id={id}").Result;
        var json = response.Content.ReadAsStringAsync().Result;
        return JsonSerializer.Deserialize<IEnumerable<User>>(json)?.FirstOrDefault();
    }
}