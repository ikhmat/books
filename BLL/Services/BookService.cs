using Abstraction.Interfaces.DataSources;
using Abstraction.Interfaces.Services;
using Mapster;
using Models.DTOs;
using Models.Entities;

namespace BLL.Services;

public class BookService : IBookService
{
    private IGenericDataSource<Book> _bookDataSource;

    public BookService(IGenericDataSource<Book> bookDataSource)
    {
        _bookDataSource = bookDataSource;
    }

    /// <inheritdoc />
    public IEnumerable<BookDTO> GetBooks()
    {
        var books =  _bookDataSource.GetItems();
        return books.ProjectToType<BookDTO>().AsEnumerable();
    }

    /// <inheritdoc />
    public async Task<int> AddBook(BookDTO bookDTO)
    {
        var book = bookDTO.Adapt<Book>();
        await _bookDataSource.AddAsync(book);
        await _bookDataSource.SaveChangesAsync();
        return book.Id;
    }
}