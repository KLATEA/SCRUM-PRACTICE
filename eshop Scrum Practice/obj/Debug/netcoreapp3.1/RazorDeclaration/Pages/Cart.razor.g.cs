#pragma checksum "C:\Users\kilen\Source\Repos\eshop Scrum Practice\eshop Scrum Practice\Pages\Cart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0a7dfc696413ba7cc49986db4fcd1e1478dba8f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace eshop_Scrum_Practice.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kilen\Source\Repos\eshop Scrum Practice\eshop Scrum Practice\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kilen\Source\Repos\eshop Scrum Practice\eshop Scrum Practice\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kilen\Source\Repos\eshop Scrum Practice\eshop Scrum Practice\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kilen\Source\Repos\eshop Scrum Practice\eshop Scrum Practice\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kilen\Source\Repos\eshop Scrum Practice\eshop Scrum Practice\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kilen\Source\Repos\eshop Scrum Practice\eshop Scrum Practice\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kilen\Source\Repos\eshop Scrum Practice\eshop Scrum Practice\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kilen\Source\Repos\eshop Scrum Practice\eshop Scrum Practice\_Imports.razor"
using eshop_Scrum_Practice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kilen\Source\Repos\eshop Scrum Practice\eshop Scrum Practice\_Imports.razor"
using eshop_Scrum_Practice.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kilen\Source\Repos\eshop Scrum Practice\eshop Scrum Practice\Pages\Cart.razor"
using eshop_Scrum_Practice.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class Cart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\kilen\Source\Repos\eshop Scrum Practice\eshop Scrum Practice\Pages\Cart.razor"
       
    private CartItem[] articles;

    protected override async Task OnInitializedAsync()
    {
        articles = await CartService.GetAllAsync();
    }

    private async Task RemoveArticleFromCart(int index)
    {
        await CartService.RemoveItemASync(index);
        articles = await CartService.GetAllAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CartService CartService { get; set; }
    }
}
#pragma warning restore 1591
