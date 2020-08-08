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
    public partial class Class1SComponent : ComponentBase
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

        protected RadzenGrid<StudentRegApp.Models.ConData.Class1> grid0;

        IEnumerable<StudentRegApp.Models.ConData.Class1> _getClass1sResult;
        protected IEnumerable<StudentRegApp.Models.ConData.Class1> getClass1sResult
        {
            get
            {
                return _getClass1sResult;
            }
            set
            {
                if (!object.Equals(_getClass1sResult, value))
                {
                    _getClass1sResult = value;
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
            var conDataGetClass1SResult = await ConData.GetClass1S();
            getClass1sResult = conDataGetClass1SResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddClass1>("Add Class 1", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(StudentRegApp.Models.ConData.Class1 args)
        {
            var dialogResult = await DialogService.OpenAsync<EditClass1>("Edit Class 1", new Dictionary<string, object>() { {"ClassID", args.ClassID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var conDataDeleteClass1Result = await ConData.DeleteClass1(data.ClassID);
                if (conDataDeleteClass1Result != null) {
                    grid0.Reload();
}
            }
            catch (System.Exception conDataDeleteClass1Exception)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Class1");
            }
        }
    }
}
