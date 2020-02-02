using davidketner.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Security.Claims;

namespace davidketner.Data.Extensions
{
    public static class UserManagerExtensions
    {
        public static string GetUserFullname(this UserManager<User> um, ClaimsPrincipal User)
        {
            return um?.Users?.FirstOrDefault(x => x.UserName == User.Identity.Name).FullName;
        }
    }

    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal principal) =>
            principal.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
