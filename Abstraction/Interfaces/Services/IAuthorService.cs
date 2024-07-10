using Models.DTOs;
using Models.Entities;

namespace Abstraction.Interfaces.Services;

public interface IAuthorService
{
    /// <summary>
    /// Method for getting all authors
    /// </summary>
    /// <returns>List of AuthorDTO</returns>
    IQueryable<AuthorDTO> GetAuthors();

    /// <summary>
    /// Method for getting author by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>AuthorDTO</returns>
    Task<AuthorDetailsDTO> GetAuthor(int id);

    /// <summary>
    /// Method for adding a new author
    /// </summary>
    /// <param name="authorDTO"></param>
    /// <returns>Identifier code of new author</returns>
    Task<int> AddAuthor(AuthorDTO authorDTO);

    /// <summary>
    /// Method for updating the author
    /// </summary>
    /// <param name="authorDTO"></param>
    /// <returns>Identifier code of the author</returns>
    Task<int> UpdateAuthor(AuthorDTO authorDTO);
}
