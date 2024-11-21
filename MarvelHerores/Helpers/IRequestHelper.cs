namespace MarvelHerores.Helpers
{
    public interface IRequestHelper
    {
        /// <summary>
        /// Crea la url completa a una ruta de la api. incluyendo la firma de la peticion
        /// </summary>
        /// <param name="path">Endpoint del recurso que se va a invocar</param>
        /// <returns></returns>
        string CreateRequestUrl(string path);
    }
}
