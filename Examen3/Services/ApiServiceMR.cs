using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
namespace ExamenProgra.Services
{
    public class ApiServiceMR
    {
        private readonly HttpClient _httpClient;
        public ApiServiceMR()
        {
            _httpClient = new HttpClient();
        }
        public async Task<string> GetJokeAsync()
        {
            var response = await _httpClient.GetStringAsync("https://api.chucknorris.io/jokes/random");
            var jokeObj = JsonConvert.DeserializeObject<JokeResponse>(response);
            return jokeObj.Value;
        }
        private class JokeResponse
        {
            [JsonProperty("value")]
            public string Value { get; set; }
        }
    }
}