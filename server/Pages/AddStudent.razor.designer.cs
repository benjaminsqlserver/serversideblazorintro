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
    public partial class AddStudentComponent : ComponentBase
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

        IEnumerable<StudentRegApp.Models.ConData.Gender> _getGendersResult;
        protected IEnumerable<StudentRegApp.Models.ConData.Gender> getGendersResult
        {
            get
            {
                return _getGendersResult;
            }
            set
            {
                if (!object.Equals(_getGendersResult, value))
                {
                    _getGendersResult = value;
                    Reload();
                }
            }
        }

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

        StudentRegApp.Models.ConData.Student _student;
        protected StudentRegApp.Models.ConData.Student student
        {
            get
            {
                return _student;
            }
            set
            {
                if (!object.Equals(_student, value))
                {
                    _student = value;
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
            var conDataGetGendersResult = await ConData.GetGenders();
            getGendersResult = conDataGetGendersResult;

            var conDataGetClass1SResult = await ConData.GetClass1S();
            getClass1sResult = conDataGetClass1SResult;

            student = new StudentRegApp.Models.ConData.Student(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(StudentRegApp.Models.ConData.Student args)
        {
            try
            {
                var conDataCreateStudentResult = await ConData.CreateStudent(student);
                DialogService.Close(student);
            }
            catch (System.Exception conDataCreateStudentException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new Student!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
