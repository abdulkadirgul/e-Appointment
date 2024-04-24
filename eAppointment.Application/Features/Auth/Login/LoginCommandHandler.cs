﻿using eAppointmentServer.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace eAppointment.Application.Features.Auth.Login
{
    internal sealed class LoginCommandHandler(UserManager<AppUser> userManager) : IRequestHandler<LoginCommand, Result<LoginCommandResponse>>
{
        public async Task<Result<LoginCommandResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser? appUser =
                await userManager.Users.FirstOrDefaultAsync(p =>
                p.UserName == request.UserNameOrEmail ||
                p.Email == request.UserNameOrEmail, cancellationToken);

            if (appUser == null)
            {
                return Result<LoginCommandResponse>.Failure("User Not Found!");
            }

            bool isPasswordCorrect = await userManager.CheckPasswordAsync(appUser, request.Password);

            if (!isPasswordCorrect)
            {
                return Result<LoginCommandResponse>.Failure("Password is wrong!");
            }

            return Result<LoginCommandResponse>.Succeed(new("Token"));
        }
    }
}