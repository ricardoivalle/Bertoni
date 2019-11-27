using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExternalServices
{
    public class ServiceHelper
    {
        private const int DEFAULT_TIMEOUT = 20;
        
        /// <summary>
        /// Sends a post request to a URL and returns the response.
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="JsonParams"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public static HttpResponseMessage Post(String URL, String JsonParams, int timeOut = DEFAULT_TIMEOUT)
        {
            var response = new HttpResponseMessage();
            response.StatusCode = HttpStatusCode.NotFound;

            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                using (var client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.Timeout = TimeSpan.FromSeconds(timeOut);

                    HttpContent content = new StringContent(JsonParams, Encoding.UTF8, "application/json");

                    //TODO: Log Request Info Here

                    response = client.PostAsync(new Uri(URL), content).Result;
                }
            }
            catch (HttpRequestException rex)
            {
               //TODO: Log Error Here
            }
            catch (TaskCanceledException tce)
            {
                //TODO: Log Error Here
                response.StatusCode = HttpStatusCode.RequestTimeout;
            }
            catch (TimeoutException tex)
            {
                //TODO: Log Error Here
                response.StatusCode = HttpStatusCode.RequestTimeout;
            }
            catch (Exception ex)
            {
                //TODO: Log Error Here
            }

            return response;
        }

        /// <summary>
        /// Sends a get request to a URL and returns the response.
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="JsonParams"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public static HttpResponseMessage Get(String URL, int timeOut = DEFAULT_TIMEOUT, string myParam = null)
        {
            var newResponse = new HttpResponseMessage();
            newResponse.StatusCode = HttpStatusCode.NotFound;

            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

                using (var client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.Timeout = TimeSpan.FromSeconds(timeOut);

                    //TODO: Log Request Info Here

                    newResponse = client.GetAsync(new Uri(URL)).Result;
                }
            }
            catch (HttpRequestException rex)
            {
                //TODO: Log Error Here
            }
            catch (TaskCanceledException tce)
            {
                //TODO: Log Error Here
                newResponse.StatusCode = HttpStatusCode.RequestTimeout;
            }
            catch (TimeoutException tex)
            {
                //TODO: Log Error Here
                newResponse.StatusCode = HttpStatusCode.RequestTimeout;
            }
            catch (Exception ex)
            {
                //TODO: Log Error Here
            }
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(URL);
            }
            return newResponse;
        }
        /// <summary>
        /// Local Blank method from branch 1
        /// </summary>
        /// <param name="localParam"></param>
        /// <returns></returns>
        public int MethodBranch1(String localParam)
        {
            return 0;
        }
    }
}
