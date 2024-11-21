namespace MarvelHerores.Services.HeroesServices
{
    public interface IMarvelService<T> where T : class
    {
        Task<T> GetAllAsync(string ts, string publicKey, string hash, int? limit = null, int? offset = null);
        Task<T> GetByIdAsync(string ts, string publicKey, string hash, int id);
    }
}
