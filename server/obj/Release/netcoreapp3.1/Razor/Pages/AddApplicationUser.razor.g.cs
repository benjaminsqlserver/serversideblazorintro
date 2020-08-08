#pragma checksum "C:\StudentRegApp\server\Pages\AddApplicationUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "807eac90f8705f886e0104e95c77bfc18503b77d"
// <auto-generated/>
#pragma warning disable 1591
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
#line 5 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
using StudentRegApp.Models.ConData;

#line default
#line hidden
#line 8 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
using StudentRegApp.Models;

#line default
#line hidden
#line 10 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
           [Authorize(Roles="Admin")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-application-user")]
    public partial class AddApplicationUser : StudentRegApp.Pages.AddApplicationUserComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ApplicationUser>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ApplicationUser>(
#line 17 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
                                                           user

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
                                                                            user != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ApplicationUser>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ApplicationUser>(this, 
#line 17 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
                                                                                                    Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Component", "Email");
                    __builder3.AddAttribute(25, "style", "width: 100%");
                    __builder3.AddAttribute(26, "Text", "Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(34, "Name", "Email");
                    __builder3.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 25 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
                                                                                  user.Email

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email))));
                    __builder3.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Email));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(39);
                    __builder3.AddAttribute(40, "Component", "Email");
                    __builder3.AddAttribute(41, "style", "position: absolute");
                    __builder3.AddAttribute(42, "Text", "Email is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(48, "class", "row");
                    __builder3.AddMarkupContent(49, "\n              ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "col-md-3");
                    __builder3.AddMarkupContent(52, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(53);
                    __builder3.AddAttribute(54, "Component", "RoleNames");
                    __builder3.AddAttribute(55, "style", "width: 100%");
                    __builder3.AddAttribute(56, "Text", "Roles");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-9");
                    __builder3.AddMarkupContent(61, "\n                ");
                    __Blazor.StudentRegApp.Pages.AddApplicationUser.TypeInference.CreateRadzenDropDown_0(__builder3, 62, 63, 
#line 37 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
                                       roles

#line default
#line hidden
                    , 64, 
#line 37 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
                                                        true

#line default
#line hidden
                    , 65, "width: 100%", 66, "Name", 67, "Name", 68, "RoleNames", 69, 
#line 37 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
                                                                                                 user.RoleNames

#line default
#line hidden
                    , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.RoleNames = __value, user.RoleNames)), 71, () => user.RoleNames);
                    __builder3.AddMarkupContent(72, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\n            ");
                    __builder3.OpenElement(75, "div");
                    __builder3.AddAttribute(76, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(77, "class", "row");
                    __builder3.AddMarkupContent(78, "\n              ");
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "class", "col-md-3");
                    __builder3.AddMarkupContent(81, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(82);
                    __builder3.AddAttribute(83, "Component", "Password");
                    __builder3.AddAttribute(84, "style", "width: 100%");
                    __builder3.AddAttribute(85, "Text", "Password");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(86, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\n              ");
                    __builder3.OpenElement(88, "div");
                    __builder3.AddAttribute(89, "class", "col-md-9");
                    __builder3.AddMarkupContent(90, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(91);
                    __builder3.AddAttribute(92, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(93, "Name", "Password");
                    __builder3.AddAttribute(94, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 47 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
                                                                                   user.Password

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(95, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                    __builder3.AddAttribute(96, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(97, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(98);
                    __builder3.AddAttribute(99, "Component", "Password");
                    __builder3.AddAttribute(100, "style", "position: absolute");
                    __builder3.AddAttribute(101, "Text", "Password is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(103, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(104, "\n            ");
                    __builder3.OpenElement(105, "div");
                    __builder3.AddAttribute(106, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(107, "class", "row");
                    __builder3.AddMarkupContent(108, "\n              ");
                    __builder3.OpenElement(109, "div");
                    __builder3.AddAttribute(110, "class", "col-md-3");
                    __builder3.AddMarkupContent(111, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(112);
                    __builder3.AddAttribute(113, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(114, "style", "width: 100%");
                    __builder3.AddAttribute(115, "Text", "Confirm password");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(116, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(117, "\n              ");
                    __builder3.OpenElement(118, "div");
                    __builder3.AddAttribute(119, "class", "col-md-9");
                    __builder3.AddMarkupContent(120, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(121);
                    __builder3.AddAttribute(122, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(123, "Name", "ConfirmPassword");
                    __builder3.AddAttribute(124, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 59 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
                                                                                   user.ConfirmPassword

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(125, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.ConfirmPassword = __value, user.ConfirmPassword))));
                    __builder3.AddAttribute(126, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.ConfirmPassword));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(127, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(128);
                    __builder3.AddAttribute(129, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(130, "style", "position: absolute");
                    __builder3.AddAttribute(131, "Text", "ConfirmPassword is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(132, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(133, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\n            ");
                    __builder3.OpenElement(135, "div");
                    __builder3.AddAttribute(136, "class", "row");
                    __builder3.AddMarkupContent(137, "\n              ");
                    __builder3.OpenElement(138, "div");
                    __builder3.AddAttribute(139, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(140, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(141);
                    __builder3.AddAttribute(142, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 67 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(143, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 67 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(144, "Icon", "save");
                    __builder3.AddAttribute(145, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(146, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(147);
                    __builder3.AddAttribute(148, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 69 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(149, "Text", "Cancel");
                    __builder3.AddAttribute(150, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 69 "C:\StudentRegApp\server\Pages\AddApplicationUser.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(151, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(152, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(153, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(154, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.StudentRegApp.Pages.AddApplicationUser
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Multiple", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "TextProperty", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591