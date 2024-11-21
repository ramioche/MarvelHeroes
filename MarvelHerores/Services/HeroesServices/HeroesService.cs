
using System.Net.Http.Json;

namespace MarvelHerores.Services.HeroesServices
{
    public class HeroesService: IMarvelService<Hero>
    {
        private readonly HttpClient _httpClient;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        public HeroesService(IHttpClientFactory client)
        {
            _httpClient = client.CreateClient("API");
        }

        public async Task<Hero> GetAllAsync(string ts, string publicKey, string hash, int? limit = null, int? offset = null)
        {
            var finalUrl = string.Format(Endpoints.Endpoints.GetAllHeroes, ts, publicKey, hash, limit ?? 5, offset ?? 0);
            var response = await _httpClient.GetFromJsonAsync<Hero>(finalUrl);
            return response;
        }

        public async Task<Hero> GetByIdAsync(string ts, string publicKey, string hash, int id)
        {
            var finalUrl = string.Format(Endpoints.Endpoints.GetHeroById, id, ts, publicKey, hash);
            var response = await _httpClient.GetFromJsonAsync<Hero>(finalUrl);
            return response;
        }
    }
}
