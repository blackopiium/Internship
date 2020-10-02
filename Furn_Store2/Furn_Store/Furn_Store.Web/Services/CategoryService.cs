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
    public class CategoryService
    {
        public HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CategoryViewModel>> GetCategoriesWithoutParameters()
        {
            var response = await _httpClient.GetAsync($"api/category");
            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<CategoryViewModel>>(responseContent);
        }
        public async Task<List<CategoryViewModel>> GetCategories(CategoryParameters parameters)
        {
            var response = await _httpClient.GetAsync($"api/category?PageSize={parameters.PageSize}&PageNumber={parameters.PageNumber}");
            if (!response.IsSuccessStatusCode)
                return null;

            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<CategoryViewModel>>(responseContent);
        }
        public async Task<HttpResponseMessage> AddCategorty(CategoryViewModel item)
        {
            return await _httpClient.PostAsync("api/category", GetStringContentFromObject(item));
        }
        public async Task<string> GetById(int id)
        {
            var response = await _httpClient.GetAsync($"api/category/{id}");
            if (!response.IsSuccessStatusCode)
                return null;

            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent;
        }
        private StringContent GetStringContentFromObject(object obj)
        {
            var serialized = JsonSerializer.Serialize(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
        public async Task<int> CountItems(CategoryParameters parameters)
        {
            var response = await _httpClient.GetAsync($"api/category/count");
            if (!response.IsSuccessStatusCode)
                return 0;
            else
                return Int32.Parse(await response.Content.ReadAsStringAsync());
        }
    }
}
