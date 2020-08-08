using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using StudentRegApp.Models.ConData;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using StudentRegApp.Models;

namespace StudentRegApp.Pages
{
    public partial class EditClass1Component : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(() => { StateHasChanged(); });
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected SecurityService Security { get; set; }

        [Inject]
        protected ConDataService ConData { get; set; }

        [Parameter]
        public dynamic ClassID { get; set; }

        StudentRegApp.Models.ConData.Class1 _class1;
        protected StudentRegApp.Models.ConData.Class1 class1
        {
            get
            {
                return _class1;
            }
            set
            {
                if (!object.Equals(_class1, value))
                {
                    _class1 = value;
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            if (!Security.IsAuthenticated())
            {
                UriHelper.NavigateTo("Login", true);
            }
            else
            {
                await Load();
            }

        }

        protected async System.Threading.Tasks.Task Load()
        {
            var conDataGetClass1ByClassIdResult = await ConData.GetClass1ByClassId(ClassID);
            class1 = conDataGetClass1ByClassIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(StudentRegApp.Models.ConData.Class1 args)
        {
            try
            {
                var conDataUpdateClass1Result = await ConData.UpdateClass1(ClassID, class1);
                DialogService.Close(class1);
            }
            catch (System.Exception conDataUpdateClass1Exception)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update Class1");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
