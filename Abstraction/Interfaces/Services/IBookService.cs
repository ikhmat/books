using Models.DTOs;

namespace Abstraction.Interfaces.Services;

public interface IBookService
{
    /// <summary>
    /// Method for getting all books
    /// </summary>
    /// <returns>List of AuthorDTO</returns>
    List<BookDTO> GetBooks();

    /// <summary>
    /// Method for adding a new book
    /// </summary>
    /// <param name="bookDTO"></param>
    /// <returns>Identifier code of new book</returns>
    Task<int> AddBook(BookDTO bookDTO);
}