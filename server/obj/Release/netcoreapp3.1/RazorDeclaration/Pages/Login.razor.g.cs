#pragma checksum "C:\StudentRegApp\server\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a0ec3d97a519da551be23711e673c9f9226d06"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StudentRegApp.Pages
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
#line 5 "C:\StudentRegApp\server\Pages\Login.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\StudentRegApp\server\Pages\Login.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\StudentRegApp\server\Pages\Login.razor"
using StudentRegApp.Models.ConData;

#line default
#line hidden
#line 8 "C:\StudentRegApp\server\Pages\Login.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "C:\StudentRegApp\server\Pages\Login.razor"
using StudentRegApp.Models;

#line default
#line hidden
#line 10 "C:\StudentRegApp\server\Pages\Login.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "C:\StudentRegApp\server\Pages\Login.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : StudentRegApp.Pages.LoginComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<ApplicationUser> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> UserManager { get; set; }
    }
}
#pragma warning restore 1591