using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace TestUploadFileWebApi.authstuff
{
    public class OnlyThirdPartiesRequirement : IAuthorizationRequirement
    {
        // This is empty, but you can have a bunch of properties and methods here if you like that you can later access from the AuthorizationHandler.
    }

    public class OnlyThirdPartiesAuthorizationHandler : AuthorizationHandler<OnlyThirdPartiesRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OnlyThirdPartiesRequirement requirement)
        {
            if (context.User.IsInRole(Roles.ThirdParty))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}