using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using MeetAndPlayMobileApp.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MeetAndPlayMobileApp.Services
{
    public class JsonAPIService
    {
        HttpClient _client;

        public JsonAPIService()
        {
#if DEBUG
            _client = new HttpClient(DependencyService.Get<IHttpClientHandlerService>().GetInsecureHandler());
#else
            client = new HttpClient();
#endif
        }

        public async Task<User> GetUserDataAsync(string uri)
        {
            User userData = null;
            try
            {
                HttpResponseMessage responseMessage = await _client.GetAsync(uri);

                if (responseMessage.IsSuccessStatusCode)
                {
                    string content = await responseMessage.Content.ReadAsStringAsync();
                    userData = JsonConvert.DeserializeObject<User>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return userData;

        }
    }
}
