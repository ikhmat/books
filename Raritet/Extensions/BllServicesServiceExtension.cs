﻿using Abstraction.Interfaces.Services;
using BLL.Services;

namespace Raritet.Extensions;

public static class BllServicesServiceExtension
{
    public static void AddBllServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthorService, AuthorService>();
        services.AddScoped<IBookService, BookService>();
    }
}