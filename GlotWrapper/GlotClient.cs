using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Glot.Models;
using Newtonsoft.Json;

namespace Glot
{
    internal class GlotClient : HttpClient
    {
        public GlotClient(string apikey)
        {
            if (apikey != null)
                base.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", apikey);
        }
        public async Task<T> GetAsync<T>(string url) where T : class
        {
            var resp = await base.GetAsync(url);
            var json = await resp.Content.ReadAsStringAsync();
            if(resp.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new HttpRequestException(json);
            }
            resp.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<T>(json);
        }

        public async Task<T> PostAsync<T>(string url, object obj) where T : class
        {
            if (obj is null)
                throw new ArgumentNullException($"{nameof(obj)} can not be null");

            var resp = await base.PostAsync(url, new StringContent(JsonConvert.SerializeObject(obj)));
            var json = await resp.Content.ReadAsStringAsync();
            if(resp.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new HttpRequestException(json);
            }
            resp.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<T>(json);
        }
        public async Task<T> PutAsync<T>(string url, object obj) where T : class
        {
            if (obj is null)
                throw new ArgumentNullException($"{nameof(obj)} can not be null");
            var resp = await base.PutAsync(url, new StringContent(JsonConvert.SerializeObject(obj)));
            var json = await resp.Content.ReadAsStringAsync();
            if(resp.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new HttpRequestException(json);
            }
            resp.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<T>(json);
        }
        public new async Task DeleteAsync(string url)
        {
            var resp = await base.DeleteAsync(url);
            resp.EnsureSuccessStatusCode();
        }
    }
}