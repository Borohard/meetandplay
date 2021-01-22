using MeetAndPlayMobileApp.Droid;
using MeetAndPlayMobileApp.Services;
using Xamarin.Forms;
using System.Net.Http;

[assembly: Dependency(typeof(HttpClientHandlerService))]
namespace MeetAndPlayMobileApp.Droid
{
    public class HttpClientHandlerService : IHttpClientHandlerService
    {
        public HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
        }
    }
}