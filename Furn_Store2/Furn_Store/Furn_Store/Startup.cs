using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using FluentValidation;
using Furn_Store.Business.DTO;
using Furn_Store.Business.Interfaces;
using Furn_Store.Business.Services;
using Furn_Store.Business.Validators;
using Furn_Store.Data.Data.EFCore;
using Furn_Store.Data.Helpers;
using Furn_Store.Data.Interfaces;
using Furn_Store.Data.Models;
using Furn_Store.Data.UnitOfWorkFolder;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.IdentityModel.Logging;
using Furn_Store.Business;
using System.Text;

namespace Furn_Store
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:FurnitureStoreDB1"]));
            #region automapper
           /* services.AddAutoMapper(cfg =>
            {
                cfg.CreateMap<Item, ItemDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
                cfg.CreateMap<Factory, FactoryDTO>();
                cfg.CreateMap<Order, OrderDTO>();
                cfg.CreateMap<Charachteristics_Item, Charachteristic_Item_DTO>();
                cfg.CreateMap<Client, ClientDTO>();
                cfg.CreateMap<Order_Items, Order_Items_DTO>();
            }, typeof(Startup));*/
            services.AddAutoMapper(typeof(MappingProfile).GetTypeInfo().Assembly);
            #endregion
            #region unitofwork
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            #endregion
            #region Repositories
            services.AddTransient<IItemRepository, ItemRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IFactoryRepository, FactoryRepository>();
            services.AddScoped<IClientRepository, CLientRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICharachteristics_ItemRepository, Charachteristics_ItemRepository>();
            services.AddScoped<IOrder_Items_Repository, Order_ItemsRepository>();
            #endregion
            #region Services
            services.AddTransient<IItemService, ItemService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IFactoryService, FactoryService>();
            services.AddTransient<ICharachteristics_Service, CharachteristicsService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IOrder_Items_Service, Order_Items_Service>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IAccountService, AccountService>();
            #endregion
            #region validators
           /* services.AddSingleton<IValidator<ItemDTO>, ItemDTOValidator>();
            services.AddSingleton<IValidator<CategoryDTO>, CategoryDTOValidator>();
            services.AddSingleton<IValidator<FactoryDTO>, FactoryDTOValidator>();
            services.AddSingleton<IValidator<ClientDTO>, ClientDTOValidator>();
            services.AddSingleton<IValidator<OrderDTO>, OrderDTOValidator>();
            services.AddSingleton<IValidator<Order_Items_DTO>, Order_Items_DTO_Validator>();
            services.AddSingleton<IValidator<Charachteristic_Item_DTO>, Charachteristircs_Item_DTO_Validator>();*/
            #endregion
            services.AddTransient<ISortHepler<Item>, SortHelper<Item>>();
            services.AddIdentity<MyUser, MyRole>(opt =>
            {
                opt.User.RequireUniqueEmail = true;

                opt.Password.RequiredLength = 6;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireNonAlphanumeric = false;

            }).AddEntityFrameworkStores<RepositoryContext>();
            services.AddMvc(option => option.EnableEndpointRouting = false)
              .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
              .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
            /* services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                 .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ItemDTOValidator>());*/
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        options.RequireHttpsMetadata = false;
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuer = true,
                            ValidIssuer = Configuration["JwtIssuer"],
                            ValidateAudience = true,
                            ValidAudience = Configuration["JwtAudience"],
                            ValidateLifetime = true,
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSecurityKey"])),
                            ValidateIssuerSigningKey = true,
                            ClockSkew = TimeSpan.Zero
                        };
                    });
            services.AddControllers();
            services.AddServerSideBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                IdentityModelEventSource.ShowPII = true;
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
