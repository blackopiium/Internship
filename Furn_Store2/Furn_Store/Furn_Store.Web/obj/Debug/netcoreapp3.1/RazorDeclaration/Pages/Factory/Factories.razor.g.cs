#pragma checksum "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8413d307611733d204cf294c90a4e1483cdcb8e3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Furn_Store.Web.Pages.Factory
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Furn_Store.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Furn_Store.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factories.razor"
using Furn_Store.Business.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factories.razor"
using ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factories.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factories.razor"
using Furn_Store.Data.Parameters;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/factories")]
    public partial class Factories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factories.razor"
       
    string orderBy;
    string[] orderByArr = new[]
    {
            "Name",
            "Name desc"
        };
    List<FactoryViewModel> factories;
    int elementCount = 0;
    int pageSize = 25;
    int pageIndex = 0;
    protected override async Task OnInitializedAsync()
    {
        FactoryParameters parameters = new FactoryParameters
        {
            PageNumber = pageIndex + 1,
            PageSize = pageSize
        };
        factories = await factoryService.GetFactories(parameters);
        elementCount = await factoryService.CountItems(parameters);
    }
    protected async Task OnPage(MatPaginatorPageEvent m)
    {
        factories = await factoryService.GetFactories(new FactoryParameters
        {
            PageNumber = m.PageIndex + 1,
            PageSize = m.PageSize,
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Factory\Factories.razor"
                                 
        });
        pageSize = m.PageSize;
        pageIndex = m.PageIndex;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment _appEnvironment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.FactoryService factoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<Factories> L { get; set; }
    }
}
#pragma warning restore 1591