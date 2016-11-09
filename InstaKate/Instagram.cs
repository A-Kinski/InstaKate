using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using InstaSharp;
using InstaSharp.Endpoints;
using InstaSharp.Models;
using InstaSharp.Models.Responses;


namespace InstaKate
{
    class Instagram// : IDisposable
    {
        private const string USER_AGENT =
    "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_3) " +
    "AppleWebKit/537.36 (KHTML, like Gecko) " +
    "Chrome/45.0.2414.0 Safari/537.36";

        private HttpClientHandler m_Handler;
        private HttpClient m_Client;

        /// <summary>
        /// Аунтификация для InstaSharp по логину/паролю
        /// </summary>
        /// <param name="username">Имя пользователя</param>
        /// <param name="password">Пароль</param>
        /// <param name="config">конфиг InstaSharp</param>
        /// <param name="scopes">требуемые права</param>
        /// <returns>OAuthResponse, необходимый для дальшего использования InstaSharp</returns>
        //public static OAuthResponse AuthByCredentials(string username, string password, InstagramConfig config, List<OAuth.Scope> scopes)
        //{
        //    //return AuthByCredentialsAsync(username, password, config, scopes).Result;
        //}
    }
}
