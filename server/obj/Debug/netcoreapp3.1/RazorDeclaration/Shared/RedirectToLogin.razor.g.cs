#pragma checksum "C:\StudentRegApp\server\Shared\RedirectToLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92824c7806c7ded2847574a02bc2d646edc6cb3a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StudentRegApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\StudentRegApp\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\StudentRegApp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\StudentRegApp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\StudentRegApp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\StudentRegApp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\StudentRegApp\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\StudentRegApp\server\_Imports.razor"
using StudentRegApp.Shared;

#line default
#line hidden
#line 8 "C:\StudentRegApp\server\_Imports.razor"
using Radzen;

#line default
#line hidden
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 3 "C:\StudentRegApp\server\Shared\RedirectToLogin.razor"
       
    [Parameter]
    public bool IsAuthenticated { get; set; }
    
    protected override void OnInitialized()
    {
        if (!IsAuthenticated)
        {
            UriHelper.NavigateTo("Login", true);
        }
        else
        {
            UriHelper.NavigateTo("Unauthorized", true);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
