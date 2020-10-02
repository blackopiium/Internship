using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Furn_Store.Web.Data;
using Furn_Store.Web.Services;
using Furn_Store.Data.Interfaces;
using Furn_Store.Data.Data.EFCore;
using Furn_Store.Data.UnitOfWorkFolder;
using Furn_Store.Business.Interfaces;
using Blazored.LocalStorage;
using Furn_Store.Web.Validators;
using FluentValidation;

namespace Furn_Store.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<HttpClient>();
            services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            services.AddBlazoredLocalStorage();
            services.AddServerSideBlazor().AddCircuitOptions(option =>
            {
                option.DetailedErrors = true;
            });
            services.AddHttpClient<ItemService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44360");
            });
            services.AddHttpClient<AccountService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44360");
            });
            services.AddHttpClient<CategoryService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44360");
            });
            services.AddHttpClient<FactoryService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44360");
            });
            services.AddHttpClient<CharachteristicsService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44360");
            });
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            var supportedCultures = new List<CultureInfo> { new CultureInfo("ua"), new CultureInfo("en") };
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("ua");
                options.SupportedUICultures = supportedCultures;
            });
            services.AddValidatorsFromAssemblyContaining<ItemViewModelValidator>();
            services.AddValidatorsFromAssemblyContaining<CategoryViewModelValidator>();
            services.AddValidatorsFromAssemblyContaining<FactoryViewModelValidator>();
            services.AddValidatorsFromAssemblyContaining<RegisterViewModelValidator>();
            services.AddValidatorsFromAssemblyContaining<LoginViewModelValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseRequestLocalization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
