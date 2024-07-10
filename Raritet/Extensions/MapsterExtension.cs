using Mapster;
using Models.DTOs;
using Models.Entities;

namespace Raritet.Extensions;

public static class MapsterExtension
{
    public static void InitMapping(this IApplicationBuilder app)
    {
        app.BookMapping();
    }

    private static void BookMapping(this IApplicationBuilder app)
    {
        TypeAdapterConfig<Book, BookDTO>.NewConfig()
            .Map(dest => dest.AuthorName, src => $"{src.Author.Surname} {src.Author.Name}");
    }
}