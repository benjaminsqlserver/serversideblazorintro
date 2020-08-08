#pragma checksum "C:\StudentRegApp\server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0f1229348bc71ff1396ca17af4cfdc83ca633e2"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\StudentRegApp\server\Shared\MainLayout.razor"
using Radzen;

#line default
#line hidden
#line 4 "C:\StudentRegApp\server\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 5 "C:\StudentRegApp\server\Shared\MainLayout.razor"
using StudentRegApp.Models.ConData;

#line default
#line hidden
#line 6 "C:\StudentRegApp\server\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 7 "C:\StudentRegApp\server\Shared\MainLayout.razor"
using StudentRegApp.Models;

#line default
#line hidden
    public partial class MainLayout : StudentRegApp.Layouts.MainLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenHeader>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row justify-content-start align-items-center");
                __builder2.AddMarkupContent(9, "\n      ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-6 d-flex align-items-center");
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(13);
                __builder2.AddAttribute(14, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.EventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#line 15 "C:\StudentRegApp\server\Shared\MainLayout.razor"
                                     SidebarToggle0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(16);
                __builder2.AddAttribute(17, "Text", "StudentRegApp");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n      ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-md-6 text-lg-right");
                __builder2.AddMarkupContent(22, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenProfileMenu>(23);
                __builder2.AddAttribute(24, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "C:\StudentRegApp\server\Shared\MainLayout.razor"
                                      Security.IsAuthenticated()

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenProfileMenuItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenProfileMenuItem>(this, 
#line 21 "C:\StudentRegApp\server\Shared\MainLayout.razor"
                                                                           Profilemenu0Click

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(28);
                    __builder3.AddAttribute(29, "Path", "profile");
                    __builder3.AddAttribute(30, "Icon", "settings");
                    __builder3.AddAttribute(31, "Text", "Profile");
                    __builder3.AddAttribute(32, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 23 "C:\StudentRegApp\server\Shared\MainLayout.razor"
                                                                                           Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(34);
                    __builder3.AddAttribute(35, "Path", "application-users");
                    __builder3.AddAttribute(36, "Icon", "person");
                    __builder3.AddAttribute(37, "Text", "Users");
                    __builder3.AddAttribute(38, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 25 "C:\StudentRegApp\server\Shared\MainLayout.razor"
                                                                                                 Security.IsInRole(new string[]{"Admin"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(40);
                    __builder3.AddAttribute(41, "Path", "application-roles");
                    __builder3.AddAttribute(42, "Icon", "security");
                    __builder3.AddAttribute(43, "Text", "Roles");
                    __builder3.AddAttribute(44, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "C:\StudentRegApp\server\Shared\MainLayout.razor"
                                                                                                   Security.IsInRole(new string[]{"Admin"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(46);
                    __builder3.AddAttribute(47, "Text", "Logout");
                    __builder3.AddAttribute(48, "Value", "Logout");
                    __builder3.AddAttribute(49, "Icon", "power_settings_new");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n          ");
                }
                ));
                __builder2.AddAttribute(51, "Template", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(52, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGravatar>(53);
                    __builder3.AddAttribute(54, "Email", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 33 "C:\StudentRegApp\server\Shared\MainLayout.razor"
                                     Security.User?.Name

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n  ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(60);
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(62, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenContentContainer>(63);
                __builder2.AddAttribute(64, "Name", "main");
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "\n    ");
                    __builder3.AddContent(67, 
#line 44 "C:\StudentRegApp\server\Shared\MainLayout.razor"
     Body

#line default
#line hidden
                    );
                    __builder3.AddMarkupContent(68, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(70, (__value) => {
#line 41 "C:\StudentRegApp\server\Shared\MainLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenSidebar>(72);
            __builder.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(74, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(75);
                __builder2.AddAttribute(76, "style", "height: 100%");
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(78, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(79);
                    __builder3.AddAttribute(80, "Path", "class-1-s");
                    __builder3.AddAttribute(81, "Text", "Classes");
                    __builder3.AddAttribute(82, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 52 "C:\StudentRegApp\server\Shared\MainLayout.razor"
                                                                       Security.IsInRole(new string[]{"Admin"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(84);
                    __builder3.AddAttribute(85, "Path", "genders");
                    __builder3.AddAttribute(86, "Text", "Genders");
                    __builder3.AddAttribute(87, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 54 "C:\StudentRegApp\server\Shared\MainLayout.razor"
                                                                     Security.IsInRole(new string[]{"Admin"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(89);
                    __builder3.AddAttribute(90, "Path", "students");
                    __builder3.AddAttribute(91, "Text", "Students");
                    __builder3.AddAttribute(92, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 56 "C:\StudentRegApp\server\Shared\MainLayout.razor"
                                                                       Security.IsInRole(new string[]{"Admin", "Teacher"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\n      ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(95, (__value) => {
#line 48 "C:\StudentRegApp\server\Shared\MainLayout.razor"
                     sidebar0 = (Radzen.Blazor.RadzenSidebar)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(96, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFooter>(97);
            __builder.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(99, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(100);
                __builder2.AddAttribute(101, "Text", "StudentRegApp, Copyright Ⓒ 2020");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(102, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591