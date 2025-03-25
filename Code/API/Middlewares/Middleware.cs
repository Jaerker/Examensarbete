using AlfaCert.Models.UserModels.User;
using AlfaCert.Repository.Data;
using AlfaCert.Shared.Library;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace AlfaCert.WebAPI.Middlewares
{

    [AttributeUsage(AttributeTargets.Class)]
    public class MiddlewareBaseAttribute : Attribute { }

    [MiddlewareBase]
    public class Middleware
    {

        private readonly RequestDelegate _next;

        public Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, UserManager<UserModel> userManager, DataContext dataContext)
        {

            var userId = context.User.FindFirstValue(ClaimTypes.UserData);
            var roles = context.User.FindAll(ClaimTypes.Role);

            if (userId != null)
            {
                if (!Guid.TryParse(userId, out var _userId))
                    throw new UnauthorizedAccessException("User data is invalid.");

                var user = await dataContext.Users.AsNoTracking()
                                    .Include(x => x.Invigilators)
                                        .ThenInclude(y => y.Company)
                                            .ThenInclude(z => z.Sector)
                                    .Include(x => x.SectorSupervisors)
                                    .Include(x => x.CompanySupervisors)
                                        .ThenInclude(y => y.Company)
                                            .ThenInclude(z => z.Sector)
                                    .Include(x => x.Admin)
                                    .Where(x => x.Id == _userId && x.BaseState != EnumState.Removed || x.Id == _userId && x.BaseState != EnumState.Hidden)
                                    .SingleOrDefaultAsync();
                if (user != null)
                {
                    context.Items["User"] = user;
                    context.Items["Roles"] = roles;
                }
            }
            await _next(context);
            return;
        }
    }
}
