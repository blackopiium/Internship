using Furn_Store.Business.DTO;
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
    public class ItemService
    {
        public HttpClient _httpClient;
        public ItemService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ItemViewModel>> GetItemsWithoutParameters()
        {
            var response = await _httpClient.GetAsync($"api/item");
            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<ItemViewModel>>(responseContent);
        }
        public async Task<List<ItemViewModel>> GetItems(ItemParameters parameters) 
        {
            var response = await _httpClient.GetAsync($"api/item?PageSize={parameters.PageSize}&PageNumber={parameters.PageNumber}&MinPrice={parameters.MinPrice}&Name={parameters.Name}&MaxPrice={parameters.MaxPrice}&OrderBy={parameters.OrderBy}");
            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<ItemViewModel>>(responseContent);
        }
        public async Task<ItemViewModel> GetItemById(int id)
        {
            var response = await _httpClient.GetAsync($"api/item/{id}");
            if (!response.IsSuccessStatusCode)
                return null;            

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<ItemViewModel>(responseContent);
        }
        public async Task<HttpResponseMessage> AddItem(ItemViewModel item)
        {
            return await _httpClient.PostAsync("api/item", GetStringContentFromObject(item));
        }
        private StringContent GetStringContentFromObject(object obj)
        {
            var serialized = JsonSerializer.Serialize(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
        public async Task<int> CountItems(ItemParameters parameters)
        {
            var response = await _httpClient.GetAsync($"api/item/count?minprice={parameters.MinPrice}&MaxPrice={parameters.MaxPrice}");
            if (!response.IsSuccessStatusCode)
                return 0;
            else
                return Int32.Parse(await response.Content.ReadAsStringAsync());
        }
    }
}
