using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RapidPayIntegration.ApiClients
{
    public class CoreApiClient
    {
        public static async Task<TResponse> DoGetAsync<THttpClient, TResponse>(THttpClient client, string url, string apiUsername, string apiPassword,  string XVerify)
         where THttpClient : HttpClient
         where TResponse : class
        {
            TResponse response = null;
            try
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(string.Format("{0}:{1}", apiUsername, apiPassword))));
                HttpResponseMessage reponseMSg = client.GetAsync(url).Result;
                if (reponseMSg.IsSuccessStatusCode)
                {
                    string Data = reponseMSg.Content.ReadAsStringAsync().Result;
                    response = JsonConvert.DeserializeObject<TResponse>(Data);
                    XVerify = reponseMSg.Headers.GetValues("X-VERIFY").FirstOrDefault();
                }
               
               
            }
            catch (HttpRequestException htpRequestException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

            return response;
        }

        public static async Task<TResponse> DoPostRequestJsonAsync<THttpClient, TRequest, TResponse>(THttpClient client, string url, TRequest request)
          where THttpClient : HttpClient
          where TResponse : class
          where TRequest : class
        {
            TResponse response = null;
            try
            {
                string stringData = JsonConvert.SerializeObject(request);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage reponseMSg = client.PostAsync(url, contentData).Result;
                if (reponseMSg.IsSuccessStatusCode)
                {
                    string Data = await reponseMSg.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<TResponse>(Data);
                }

              
            }
            catch (HttpRequestException htpRequestException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

            return response;
        }

        public static async Task<TResponse> DoPostRequestJsonAsyncWithCredential<THttpClient, TRequest, TResponse>
            (THttpClient client, string url, TRequest request, string apiUsername, string apiPassword)
            where THttpClient : HttpClient
            where TResponse : class
             where TRequest : class
        {
            TResponse response = null;
            try
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(string.Format("{0}:{1}", apiUsername, apiPassword))));
                string stringData = JsonConvert.SerializeObject(request);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage reponseMSg = client.PostAsync(url, contentData).Result;
                if (reponseMSg.IsSuccessStatusCode)
                {
                    string Data = await reponseMSg.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<TResponse>(Data);
                }
            }
            catch (HttpRequestException htpRequestException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

            return response;
        }

        public static async Task<string> DoPostRequestJsonAndGetStringAsync<THttpClient, TRequest>(THttpClient client, string url, TRequest request)
          where THttpClient : HttpClient
          where TRequest : class
        {
            string Data = string.Empty;
            try
            {

                string stringData = JsonConvert.SerializeObject(request);

                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage reponseMSg = client.PostAsync(url, contentData).Result;
                if (reponseMSg.IsSuccessStatusCode)
                {
                    Data = await reponseMSg.Content.ReadAsStringAsync();
                }
            }
            catch (HttpRequestException htpRequestException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

            return Data;
        }


    }
}
