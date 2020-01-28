using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace TestUploadFileWebApi.authstuff
{
    public class OnlyManagersRequirement : IAuthorizationRequirement
    {
        // This is empty, but you can have a bunch of properties and methods here if you like that you can later access from the AuthorizationHandler.
    }

    public class OnlyManagersAuthorizationHandler : AuthorizationHandler<OnlyManagersRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OnlyManagersRequirement requirement)
        {
            if (context.User.IsInRole(Roles.Manager))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}