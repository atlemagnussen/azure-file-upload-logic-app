using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace TestUploadFileWebApi.authstuff
{
    public class OnlyEmployeesRequirement : IAuthorizationRequirement
    {
        // This is empty, but you can have a bunch of properties and methods here if you like that you can later access from the AuthorizationHandler.
    }

    public class OnlyEmployeesAuthorizationHandler : AuthorizationHandler<OnlyEmployeesRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OnlyEmployeesRequirement requirement)
        {
            if (context.User.IsInRole(Roles.Employee))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}