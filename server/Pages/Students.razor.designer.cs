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
    public partial class StudentsComponent : ComponentBase
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

        protected RadzenGrid<StudentRegApp.Models.ConData.Student> grid0;

        IEnumerable<StudentRegApp.Models.ConData.Student> _getStudentsResult;
        protected IEnumerable<StudentRegApp.Models.ConData.Student> getStudentsResult
        {
            get
            {
                return _getStudentsResult;
            }
            set
            {
                if (!object.Equals(_getStudentsResult, value))
                {
                    _getStudentsResult = value;
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
            var conDataGetStudentsResult = await ConData.GetStudents();
            getStudentsResult = conDataGetStudentsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddStudent>("Add Student", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(StudentRegApp.Models.ConData.Student args)
        {
            var dialogResult = await DialogService.OpenAsync<EditStudent>("Edit Student", new Dictionary<string, object>() { {"StudentID", args.StudentID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var conDataDeleteStudentResult = await ConData.DeleteStudent(data.StudentID);
                if (conDataDeleteStudentResult != null) {
                    grid0.Reload();
}
            }
            catch (System.Exception conDataDeleteStudentException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Student");
            }
        }
    }
}
