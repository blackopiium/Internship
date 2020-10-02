using Furn_Store.Data.Parameters;
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
    public class FactoryService
    {

        public HttpClient _httpClient;
        public FactoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<FactoryViewModel>> GetFactoriesWithoutParameters()
        {
            var response = await _httpClient.GetAsync($"api/factory");
            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<FactoryViewModel>>(responseContent);
        }
        public async Task<List<FactoryViewModel>> GetFactories(FactoryParameters parameters)
        {
            var response = await _httpClient.GetAsync($"api/factory?PageSize={parameters.PageSize}&PageNumber={parameters.PageNumber}");
            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<FactoryViewModel>>(responseContent);
        }
        public async Task<string> GetFactoryById(int id)
        {
            var response = await _httpClient.GetAsync($"api/factory/{id}");
            if (!response.IsSuccessStatusCode)
                return null;

            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent;
        }
        public async Task<HttpResponseMessage> AddFactory(FactoryViewModel item)
        {
            return await _httpClient.PostAsync("api/factory", GetStringContentFromObject(item));
        }
        public async Task<int> CountItems(FactoryParameters parameters)
        {
            var response = await _httpClient.GetAsync($"api/factory/count");
            if (!response.IsSuccessStatusCode)
                return 0;
            else
                return Int32.Parse(await response.Content.ReadAsStringAsync());
        }
        private StringContent GetStringContentFromObject(object obj)
        {
            var serialized = JsonSerializer.Serialize(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
