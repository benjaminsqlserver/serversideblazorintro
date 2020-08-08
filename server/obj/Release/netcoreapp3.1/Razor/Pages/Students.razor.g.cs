#pragma checksum "C:\StudentRegApp\server\Pages\Students.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d746b94332fe190782778c4309064fbd09ab9f7"
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
#line 5 "C:\StudentRegApp\server\Pages\Students.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\StudentRegApp\server\Pages\Students.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\StudentRegApp\server\Pages\Students.razor"
using StudentRegApp.Models.ConData;

#line default
#line hidden
#line 8 "C:\StudentRegApp\server\Pages\Students.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "C:\StudentRegApp\server\Pages\Students.razor"
using StudentRegApp.Models;

#line default
#line hidden
#line 10 "C:\StudentRegApp\server\Pages\Students.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "C:\StudentRegApp\server\Pages\Students.razor"
           [Authorize(Roles="Admin, Teacher")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Students : StudentRegApp.Pages.StudentsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Students");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 19 "C:\StudentRegApp\server\Pages\Students.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<StudentRegApp.Models.ConData.Student>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "C:\StudentRegApp\server\Pages\Students.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "C:\StudentRegApp\server\Pages\Students.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "C:\StudentRegApp\server\Pages\Students.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<StudentRegApp.Models.ConData.Student>>(
#line 21 "C:\StudentRegApp\server\Pages\Students.razor"
                                                                                                     getStudentsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<StudentRegApp.Models.ConData.Student>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<StudentRegApp.Models.ConData.Student>(this, 
#line 21 "C:\StudentRegApp\server\Pages\Students.razor"
                                                                                                                                                                                 Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<StudentRegApp.Models.ConData.Student>>(28);
                    __builder3.AddAttribute(29, "Property", "FirstName");
                    __builder3.AddAttribute(30, "Title", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<StudentRegApp.Models.ConData.Student>>(32);
                    __builder3.AddAttribute(33, "Property", "MiddleName");
                    __builder3.AddAttribute(34, "Title", "Middle Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<StudentRegApp.Models.ConData.Student>>(36);
                    __builder3.AddAttribute(37, "Property", "Surname");
                    __builder3.AddAttribute(38, "Title", "Surname");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<StudentRegApp.Models.ConData.Student>>(40);
                    __builder3.AddAttribute(41, "FilterProperty", "Gender.GenderName");
                    __builder3.AddAttribute(42, "Property", "GenderID");
                    __builder3.AddAttribute(43, "SortProperty", "Gender.GenderName");
                    __builder3.AddAttribute(44, "Title", "Gender");
                    __builder3.AddAttribute(45, "Template", (Microsoft.AspNetCore.Components.RenderFragment<StudentRegApp.Models.ConData.Student>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(46, "\n              ");
                        __builder4.AddContent(47, 
#line 31 "C:\StudentRegApp\server\Pages\Students.razor"
                data.Gender?.GenderName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(48, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<StudentRegApp.Models.ConData.Student>>(50);
                    __builder3.AddAttribute(51, "Property", "Photo");
                    __builder3.AddAttribute(52, "Title", "Photo");
                    __builder3.AddAttribute(53, "Template", (Microsoft.AspNetCore.Components.RenderFragment<StudentRegApp.Models.ConData.Student>)((studentRegAppModelsConDataStudent) => (__builder4) => {
                        __builder4.AddMarkupContent(54, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenImage>(55);
                        __builder4.AddAttribute(56, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 36 "C:\StudentRegApp\server\Pages\Students.razor"
                                     studentRegAppModelsConDataStudent.Photo

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(57, "style", "height: 30px; width: 30px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(58, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<StudentRegApp.Models.ConData.Student>>(60);
                    __builder3.AddAttribute(61, "FilterProperty", "Class1.ClassName");
                    __builder3.AddAttribute(62, "Property", "CurrentClassID");
                    __builder3.AddAttribute(63, "SortProperty", "Class1.ClassName");
                    __builder3.AddAttribute(64, "Title", "Current Class");
                    __builder3.AddAttribute(65, "Template", (Microsoft.AspNetCore.Components.RenderFragment<StudentRegApp.Models.ConData.Student>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(66, "\n              ");
                        __builder4.AddContent(67, 
#line 42 "C:\StudentRegApp\server\Pages\Students.razor"
                data.Class1?.ClassName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(68, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<StudentRegApp.Models.ConData.Student>>(70);
                    __builder3.AddAttribute(71, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 45 "C:\StudentRegApp\server\Pages\Students.razor"
                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(72, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 45 "C:\StudentRegApp\server\Pages\Students.razor"
                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(73, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 45 "C:\StudentRegApp\server\Pages\Students.razor"
                                                                                                                          TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(74, "Width", "70px");
                    __builder3.AddAttribute(75, "Template", (Microsoft.AspNetCore.Components.RenderFragment<StudentRegApp.Models.ConData.Student>)((studentRegAppModelsConDataStudent) => (__builder4) => {
                        __builder4.AddMarkupContent(76, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(77);
                        __builder4.AddAttribute(78, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 47 "C:\StudentRegApp\server\Pages\Students.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(79, "Icon", "close");
                        __builder4.AddAttribute(80, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 47 "C:\StudentRegApp\server\Pages\Students.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(81, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 47 "C:\StudentRegApp\server\Pages\Students.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, studentRegAppModelsConDataStudent)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(82, "onclick", 
#line 47 "C:\StudentRegApp\server\Pages\Students.razor"
                                                                                                                                                                                                                 true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(83, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(85, (__value) => {
#line 21 "C:\StudentRegApp\server\Pages\Students.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<StudentRegApp.Models.ConData.Student>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
