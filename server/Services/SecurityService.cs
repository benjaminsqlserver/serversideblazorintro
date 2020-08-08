using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components;
using System.Security.Claims;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Components.Authorization;
using StudentRegApp.Models;
using StudentRegApp.Data;

namespace StudentRegApp
{
    public class SecurityService
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IWebHostEnvironment env;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly NavigationManager uriHelper;
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public SecurityService(ApplicationIdentityDbContext context,
            IWebHostEnvironment env,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<ApplicationUser> signInManager,
            IHttpContextAccessor httpContextAccessor,
            NavigationManager uriHelper,
            AuthenticationStateProvider authenticationStateProvider)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.env = env;
            this.httpContextAccessor = httpContextAccessor;
            this.uriHelper = uriHelper;
            this.authenticationStateProvider = authenticationStateProvider;
        }

        public ApplicationIdentityDbContext context { get; set; }

        private ApplicationUser user;

        public ApplicationUser User
        {
            get
            {
                var name = Principal.Identity.Name;

                if (env.EnvironmentName == "Development" && name == "admin")
                {
                    return new ApplicationUser { UserName = name };
                }

                if (name == null)
                {
                    return new ApplicationUser { Name = "Anonymous" };
                }

                if (user == null && name != null)
                {
                    user = userManager.FindByEmailAsync(name).Result;
                }

                return user;
            }
        }

        public ClaimsPrincipal Principal
        {
            get
            {
                return authenticationStateProvider.GetAuthenticationStateAsync().Result.User;
            }
        }

        public bool IsInRole(params string[] roles)
        {
            if (roles.Contains("Everybody"))
            {
                return true;
            }

            if (!IsAuthenticated())
            {
                return false;
            }

            if (roles.Contains("Authenticated"))
            {
                return true;
            }

            return roles.Any(role => Principal.IsInRole(role));
        }

        public bool IsAuthenticated()
        {
            return Principal.Identity.IsAuthenticated;
        }

        public async Task Logout()
        {
            uriHelper.NavigateTo("Account/Logout", true);
        }

        public async Task<bool> Login(string userName, string password)
        {
            uriHelper.NavigateTo("Login", true);

            return true;
        }

        public async Task<IEnumerable<IdentityRole>> GetRoles()
        {
            return await Task.FromResult(roleManager.Roles);
        }

        public async Task<IdentityRole> CreateRole(IdentityRole role)
        {
            var result = await roleManager.CreateAsync(role);

            EnsureSucceeded(result);

            return role;
        }

        public async Task<IdentityRole> DeleteRole(string id)
        {
            var item = context.Roles
                .Where(i => i.Id == id)
                .FirstOrDefault();

            context.Roles.Remove(item);
            context.SaveChanges();

            return item;
        }

        public async Task<IdentityRole> GetRoleById(string id)
        {
            return await Task.FromResult(context.Roles.Find(id));
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsers()
        {
            return await Task.FromResult(context.Users);
        }

        public async Task<ApplicationUser> CreateUser(ApplicationUser user)
        {
            user.UserName = user.Email;

            var result = await userManager.CreateAsync(user, user.Password);

            EnsureSucceeded(result);

            var roles = user.RoleNames;

            if (roles != null && roles.Any())
            {
                result = await userManager.AddToRolesAsync(user, roles);
                EnsureSucceeded(result);
            }

            user.RoleNames = roles;

            return user;
        }

        public async Task<ApplicationUser> DeleteUser(string id)
        {
            var item = context.Users
              .Where(i => i.Id == id)
              .FirstOrDefault();

            context.Users.Remove(item);
            context.SaveChanges();

            return item;
        }

        public async Task<ApplicationUser> GetUserById(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user != null)
            {
                user.RoleNames = await userManager.GetRolesAsync(user);
            }

            return await Task.FromResult(user);
        }

        public async Task<ApplicationUser> UpdateUser(string id, ApplicationUser user)
        {
            var roles = user.RoleNames.ToArray();

            var result = await userManager.RemoveFromRolesAsync(user, await userManager.GetRolesAsync(user));

            EnsureSucceeded(result);

            if (roles.Any())
            {
                result = await userManager.AddToRolesAsync(user, roles);

                EnsureSucceeded(result);
            }

            result = await userManager.UpdateAsync(user);

            EnsureSucceeded(result);

            if (!String.IsNullOrEmpty(user.Password) && user.Password == user.ConfirmPassword)
            {
                result = await userManager.RemovePasswordAsync(user);

                EnsureSucceeded(result);

                result = await userManager.AddPasswordAsync(user, user.Password);

                EnsureSucceeded(result);
            }

            return user;
        }

        private void EnsureSucceeded(IdentityResult result)
        {
            if (!result.Succeeded)
            {
                var message = string.Join(", ", result.Errors.Select(error => error.Description));

                throw new ApplicationException(message);
            }
        }
    }
}
