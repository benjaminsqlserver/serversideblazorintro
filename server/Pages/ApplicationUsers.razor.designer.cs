﻿using System;
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
    public partial class ApplicationUsersComponent : ComponentBase
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

        protected RadzenGrid<ApplicationUser> grid0;

        IEnumerable<ApplicationUser> _users;
        protected IEnumerable<ApplicationUser> users
        {
            get
            {
                return _users;
            }
            set
            {
                if (!object.Equals(_users, value))
                {
                    _users = value;
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
            var securityGetUsersResult = await Security.GetUsers();
            users = securityGetUsersResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddApplicationUser>("Add Application User", null);
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(ApplicationUser args)
        {
            var dialogResult = await DialogService.OpenAsync<EditApplicationUser>("Edit Application User", new Dictionary<string, object>() { {"Id", args.Id} });
            await InvokeAsync(() => { StateHasChanged(); });

            grid0.Reload();
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, ApplicationUser data)
        {
            try
            {
                var securityDeleteUserResult = await Security.DeleteUser($"{data.Id}");
                if (securityDeleteUserResult != null) {
                    grid0.Reload();
}
            }
            catch (System.Exception securityDeleteUserException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete user");
            }
        }
    }
}
