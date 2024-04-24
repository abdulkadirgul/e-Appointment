using eAppointmentServer.Domain.Entities;

namespace eAppointment.Application.Services
{
    public interface IJwtProvider
    {
        string CreateToken(AppUser user);
    }
}
