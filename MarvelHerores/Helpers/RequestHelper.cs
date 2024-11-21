using System.Security.Cryptography;
using System.Text;

namespace MarvelHerores.Helpers
{
    public class RequestHelper : IRequestHelper
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public RequestHelper(IConfiguration configuration)
        {
                _configuration = configuration;
        }
        public string CreateRequestUrl(string path)
        {
            return string.Empty;
        }

        private string GenerateMd5Sign()
        {
            var ts = TimeSpan.FromTicks(DateTime.Now.Ticks);
            var dataToConvert = string.Concat(ts, _configuration["PrivateKey"], _configuration["PrivateKey"]);
            var bytesToHash = Encoding.UTF8.GetBytes(dataToConvert);
            using var md5 = MD5.Create();
            var bytesHasheds = md5.ComputeHash(bytesToHash);
            return BitConverter.ToString(bytesHasheds).Replace("-", "").ToLower();
        }
    }
}
