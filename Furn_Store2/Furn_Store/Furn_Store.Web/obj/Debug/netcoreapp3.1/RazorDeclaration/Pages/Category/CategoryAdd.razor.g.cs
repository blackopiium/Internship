#pragma checksum "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Category\CategoryAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3368f7ff1223fedf03fd68a70ca249e08ed52944"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Furn_Store.Web.Pages.Category
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
#line 2 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Category\CategoryAdd.razor"
using ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Category\CategoryAdd.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Category\CategoryAdd.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Category\CategoryAdd.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories/add")]
    public partial class CategoryAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Admin\OneDrive\Документы\Furniture_Store\Furn_Store2\Furn_Store\Furn_Store.Web\Pages\Category\CategoryAdd.razor"
           
        private CategoryViewModel Category { get; set; } = new CategoryViewModel();
        public string Name { get; set; }
        public string Description { get; set; }
        public string Error { get; set; }
        IFileListEntry file;
        void HandleFileSelected(IFileListEntry[] files)
        {
            file = files.FirstOrDefault();
        }

        protected async Task Insert()
        {
            Error = "";
            try
            {

                string Path;
                if (file == null)
                    throw new Exception("File not found");
                if (file.Type != "image/jpeg")
                    throw new Exception("File in the wrong format! Please use .jpg");
                Path = await AddFile(file);
                Category.imagePath = Path;

                var result= await categoryService.AddCategorty(Category);
                if (!result.IsSuccessStatusCode)
                    throw new Exception(result.StatusCode.ToString());
                ClearFields();
            }
            catch (Exception e)
            {
                Error = e.Message;
            }
        }
        protected void ClearFields()
        {
            Category.name = "";
            Category.description = "";
            file = null;
        }
        protected async Task<string> AddFile(IFileListEntry uploadedFile)
        {
            if (uploadedFile != null)
            {
                var newFile = await uploadedFile.ToImageFileAsync("image/jpeg", 720, 310);

                var date = DateTime.Now;
                string path = "/category_image/"
                    + $"{date.Year}_{date.Month}_{date.Day}_{date.Hour}_{date.Minute}_{date.Second}_"
                    + newFile.Name;

                using (var filestream = new FileStream(_appEnviroment.WebRootPath + path, FileMode.Create))
                {
                    await newFile.Data.CopyToAsync(filestream);
                }

                return path;
            }
            else
                return null;

        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.CategoryService categoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment _appEnviroment { get; set; }
    }
}
#pragma warning restore 1591
