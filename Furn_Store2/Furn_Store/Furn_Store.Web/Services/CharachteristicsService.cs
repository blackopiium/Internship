using Furn_Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Furn_Store.Web.Services
{
    public class CharachteristicsService
    {
        public HttpClient _httpClient;
        public CharachteristicsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Charachterisitics_Item_ViewModel>> GetCharachterisitcs()
        {
            var response = await _httpClient.GetAsync($"api/charachteristics");
            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<Charachterisitics_Item_ViewModel>>(responseContent);
        }
        public async Task<string> GetCharById(int id)
        {
            var response = await _httpClient.GetAsync($"api/charachteristics/{id}");
            if (!response.IsSuccessStatusCode)
                return null;

           var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent;
        }
        public async Task<HttpResponseMessage> AddCharach(Charachterisitics_Item_ViewModel charachterisitics)
        {
            return await _httpClient.PostAsync("api/charachteristics", GetStringContentFromObject(charachterisitics));
        }
        private StringContent GetStringContentFromObject(object obj)
        {
            var serialized = JsonSerializer.Serialize(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}

