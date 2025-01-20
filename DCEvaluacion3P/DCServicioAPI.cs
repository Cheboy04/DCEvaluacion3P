using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCEvaluacion3P.Models;
using Newtonsoft.Json;

namespace DCEvaluacion3P
{
    public class DCServicioAPI
    {
        private readonly HttpClient _httpClient;

        public DCServicioAPI()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(DCApiSettings.CatApiBaseUrl)
            };
            _httpClient.DefaultRequestHeaders.Add("x-api-key", DCApiSettings.ApiKey);
        }

        public async Task<List<DCCat>> GetBreedsAsync()
        {
            var response = await _httpClient.GetAsync("breeds");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<DCCat>>(json);
            }
            return new List<DCCat>();
        }
    }
}
