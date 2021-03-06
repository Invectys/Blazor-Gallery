#pragma checksum "D:\GitHub\Blazor-Gallery\BlazorClient\BlazorGallery\SimpleGallery.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11d8e3fcf5cb65d4a94a4d98500ca9e9ebdf1ceb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorGallery
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GitHub\Blazor-Gallery\BlazorClient\BlazorGallery\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class SimpleGallery : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "D:\GitHub\Blazor-Gallery\BlazorClient\BlazorGallery\SimpleGallery.razor"
 if (GalleryMaker != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "def_gallery");
            __builder.AddAttribute(2, "style", "columns:" + " " + (
#nullable restore
#line 4 "D:\GitHub\Blazor-Gallery\BlazorClient\BlazorGallery\SimpleGallery.razor"
                                               GalleryMaker.ColumnAmount

#line default
#line hidden
#nullable disable
            ) + ";");
#nullable restore
#line 5 "D:\GitHub\Blazor-Gallery\BlazorClient\BlazorGallery\SimpleGallery.razor"
         foreach (var image in GalleryMaker.Images)
        {
            var base64 = Convert.ToBase64String(image);
            string url = String.Format("data:image/jpg;base64, {0}", base64);

            if (ChildContent == null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "src", 
#nullable restore
#line 12 "D:\GitHub\Blazor-Gallery\BlazorClient\BlazorGallery\SimpleGallery.razor"
                           url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "class", "def_image");
            __builder.CloseElement();
#nullable restore
#line 13 "D:\GitHub\Blazor-Gallery\BlazorClient\BlazorGallery\SimpleGallery.razor"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, 
#nullable restore
#line 16 "D:\GitHub\Blazor-Gallery\BlazorClient\BlazorGallery\SimpleGallery.razor"
                 ChildContent(url)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 16 "D:\GitHub\Blazor-Gallery\BlazorClient\BlazorGallery\SimpleGallery.razor"
                                  
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 20 "D:\GitHub\Blazor-Gallery\BlazorClient\BlazorGallery\SimpleGallery.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\GitHub\Blazor-Gallery\BlazorClient\BlazorGallery\SimpleGallery.razor"
       


    [Parameter] public GalleryMaker GalleryMaker { get; set; }
    [Parameter] public RenderFragment<string> ChildContent { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
