#pragma checksum "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aa1ad7f46b1d1c93cd2aa54df113ca831f8b5b6"
// <auto-generated/>
#pragma warning disable 1591
namespace Furn_Store.Web.Pages.Item
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
#line 1 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
using Furn_Store.Business.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
using ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
using Furn_Store.Data.Parameters;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/items")]
    public partial class Items : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenComponent<MatBlazor.MatPaginator>(2);
            __builder.AddAttribute(3, "Length", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                           elementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                                    pageSize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Page", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MatBlazor.MatPaginatorPageEvent>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MatBlazor.MatPaginatorPageEvent>(this, 
#nullable restore
#line 28 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                                                     OnPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", "display:flex; justify-content: flex-end;");
            __builder.AddMarkupContent(10, "\r\n    ");
            __Blazor.Furn_Store.Web.Pages.Item.Items.TypeInference.CreateMatSelectItem_0(__builder, 11, 12, 
#nullable restore
#line 33 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                                  orderByArr

#line default
#line hidden
#nullable disable
            , 13, 
#nullable restore
#line 33 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                 orderBy

#line default
#line hidden
#nullable disable
            , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => orderBy = __value, orderBy)), 15, () => orderBy);
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "style", "display: flex; flex-direction: column; align-items: flex-begin; width: 100%; padding: 0;");
            __builder.AddMarkupContent(20, "\r\n\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "style", "width: auto;  padding: 0");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "style", "margin: 0");
            __builder.AddContent(26, 
#nullable restore
#line 42 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                              L["Ціна"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, ":");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "number");
            __builder.AddAttribute(31, "min", "0");
            __builder.AddAttribute(32, "max", 
#nullable restore
#line 43 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                           float.MaxValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "step", "0.01");
            __builder.AddAttribute(34, "placeholder", 
#nullable restore
#line 43 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                                                                                      L["Мінімальна ціна"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                                                              minPrice

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => minPrice = __value, minPrice, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        -\r\n        ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "number");
            __builder.AddAttribute(40, "min", "0");
            __builder.AddAttribute(41, "max", 
#nullable restore
#line 45 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                           float.MaxValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "step", "0.01");
            __builder.AddAttribute(43, "placeholder", 
#nullable restore
#line 45 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                                                                                      L["Максимальна ціна"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                                                              maxPrice

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => maxPrice = __value, maxPrice, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n    <br>\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "style", "width: auto; left: 5%");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, "<p style=\"margin: 0\">Пошук:</p>\r\n        ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "text");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                  Namein

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Namein = __value, Namein));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                          Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "class", "btn btn-sm btn-primary");
            __builder.AddMarkupContent(60, "Пошук");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n\r\n");
#nullable restore
#line 57 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
 if (items == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "    ");
            __builder.OpenElement(65, "p");
            __builder.OpenElement(66, "em");
            __builder.AddContent(67, 
#nullable restore
#line 59 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
            L["Не знайдено"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 60 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(69, "    \r\n");
            __builder.AddMarkupContent(70, "    \r\n");
#nullable restore
#line 76 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
     foreach (var item in items)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "        ");
            __builder.OpenComponent<Furn_Store.Web.Pages.Item.Item>(72);
            __builder.AddAttribute(73, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                     item.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                     item.id.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "ImageSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                                                       item.imagePath

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "Price", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                                                                               item.price.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 88 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                  
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
       
    public List<CategoryViewModel> Categories;
    public List<string> CategoriesName = new List<string>();
    public string Category { get; set; }
    string Namein;
    int pageSize = 25;
    int pageIndex = 0;
    int elementCount = 0;
    string orderBy;
    string[] orderByArr = new[]
    {
            "Price",
            "Price desc",
            "Name",
            "Name desc"
        };
    float minPrice = 0;
    float maxPrice = float.MaxValue;
    List<ItemViewModel> items;
    protected override async Task OnInitializedAsync()
    {
        ItemParameters parameters = new ItemParameters
        {
            PageNumber = pageIndex + 1,
            PageSize = pageSize,
            MaxPrice = float.MaxValue,
            MinPrice = 0,
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
                                  
        };
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Item\Items.razor"
               
    items = await itemService.GetItems(parameters);
    elementCount = await itemService.CountItems(parameters);
}
protected async Task OnPage(MatPaginatorPageEvent m)
{
    items = await itemService.GetItems(new ItemParameters
    {
        PageNumber = m.PageIndex + 1,
        PageSize = m.PageSize,
        MinPrice = minPrice,
        MaxPrice = maxPrice,
        OrderBy = orderBy,
        Name=Namein
    });
    pageSize = m.PageSize;
    pageIndex = m.PageIndex;
}
protected async Task Search()
{
    ItemParameters parameters = new ItemParameters
    {
        PageNumber = pageIndex + 1,
        PageSize = pageSize,
        Name = Namein,
        MinPrice = minPrice,
        MaxPrice = maxPrice,
        OrderBy = orderBy
    };
    items = await itemService.GetItems(parameters);
    elementCount = await itemService.CountItems(parameters);
}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment _appEnvironment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ItemService itemService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.CategoryService categoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<Items> L { get; set; }
    }
}
namespace __Blazor.Furn_Store.Web.Pages.Item.Items
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatSelectItem_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IReadOnlyList<TValue> __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelectItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
