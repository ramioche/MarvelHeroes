namespace MarvelHerores.Endpoints
{
    public static class Endpoints
    {
        #region Heroes
        /// <summary>
        /// Url para obtener todos los heroes de marvel
        /// se debe hacer string.format para llenar los parametros:
        /// ts, apikey, hash, limit y ofset. en ese orden
        /// </summary>
        public const string GetAllHeroes = "?ts={0}&apikey={1}&hash={2}&limit={3}&offset={4}";

        /// <summary>
        /// Obtener un heroe por su id.
        /// hacer string.formar para llenar los parametros id, ts, apikey, hash en ese orden
        /// </summary>
        public const string GetHeroById = "characters/{id}?ts={0}&apikey={1}&hash={2}"; 
        #endregion
    }
}
