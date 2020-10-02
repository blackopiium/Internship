using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Furn_Store.Web.ViewModels;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;
using Furn_Store.Business.DTO.Identity;
using System.Net.Http.Headers;

namespace Furn_Store.Web.Services
{
    public class AccountService
    {
        public HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;
        public AccountService(HttpClient client, AuthenticationStateProvider authenticationStateProvider, ILocalStorageService localStorage)
        {
            _httpClient = client;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }
        public async Task<HttpResponseMessage> CreateUserAsync(RegisterViewModel user)
        {
            return await _httpClient.PostAsync("api/account/register", GetStringContentFromObject(user));
        }
        public async Task<LoginToken> Login(LoginViewModel login)
        {
            var response = await _httpClient.PostAsync("api/account/login", GetStringContentFromObject(login));

            using var responseContent = await response.Content.ReadAsStreamAsync();
            var loginToken = await JsonSerializer.DeserializeAsync<LoginToken>(responseContent);
            if (!response.IsSuccessStatusCode)
            {
                return loginToken;
            }

            await _localStorage.SetItemAsync("authToken", $"{loginToken.token}");

            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginToken.token);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginToken.token);
            return loginToken;
        }
        public async Task Exit()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
        private StringContent GetStringContentFromObject(object obj)
        {
            var serialized = JsonSerializer.Serialize(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
