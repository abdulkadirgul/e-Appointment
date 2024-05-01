using eAppointmentServer.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace eAppointmentServer.WebAPI
{
    public static class UserCreatorHelper
    {
        public static async Task CreateUserAsync(WebApplication app)
        {
            using (var scoped = app.Services.CreateScope())
            {
                var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

                if (!userManager.Users.Any())
                {
                   await userManager.CreateAsync(new()
                         {
                            FirstName = "Abduladir",
                            LastName = "GÜL",
                            Email = "adminKadir@adminKadir.com",
                            UserName = "admin",
                        
                         }, "1");
                }
            }
        }
    }
}
