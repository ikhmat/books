using Abstraction.Interfaces.Services;
using Models.DTOs;
using Abstraction.Interfaces.DataSources;
using Mapster;
using Models.Entities;

namespace BLL.Services;

public class AuthorService : IAuthorService
{
    private readonly IAuthorDataSource _authorDataSource;

    public AuthorService(IAuthorDataSource authorDataSource)
    {
        _authorDataSource = authorDataSource;
    }

    /// <inheritdoc />
    public List<AuthorDTO> GetAuthors()
    {
        return _authorDataSource.GetItems()
            .ProjectToType<AuthorDTO>()
            .ToList();
    }

    /// <inheritdoc />
    public async Task<AuthorDetailsDTO> GetAuthor(int id)
    {
        var author = await _authorDataSource.GetAuthorWithBooks(x => x.Id == id)
                     ?? throw new ArgumentException();

        return author.Adapt<AuthorDetailsDTO>();
    }

    /// <inheritdoc />
    public async Task<int> AddAuthor(AuthorDTO authorDTO)
    {
        var author = authorDTO.Adapt<Author>();
        author = await _authorDataSource.AddAsync(author);
        await _authorDataSource.SaveChangesAsync();
        return author.Id;
    }

    /// <inheritdoc />
    public Task<int> UpdateAuthor(AuthorDTO authorDTO)
    {
        throw new NotImplementedException();
    }
}
