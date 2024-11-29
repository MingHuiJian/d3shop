﻿using NetCorePal.D3Shop.Web.Admin.Client.Services;
using NetCorePal.D3Shop.Web.Blazor.Services;

namespace NetCorePal.D3Shop.Web.Blazor;

public static class BlazorServiceExtensions
{
    public static void AddClientServices(this IServiceCollection services)
    {
        services.AddScoped<IRolesService, RolesService>();
        services.AddScoped<IAdminUserService, AdminUserService>();
    }
}