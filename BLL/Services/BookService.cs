using Abstraction.Interfaces.DataSources;
using Abstraction.Interfaces.Services;
using Mapster;
using Models.DTOs;
using Models.Entities;

namespace BLL.Services;

public class BookService : IBookService
{
    private readonly IGenericDataSource<Book> _bookDataSource;

    public BookService(IGenericDataSource<Book> bookDataSource)
    {
        _bookDataSource = bookDataSource;
    }

    /// <inheritdoc />
    public List<BookDTO> GetBooks()
    {
        return _bookDataSource.GetItems()
            .ProjectToType<BookDTO>()
            .ToList();
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