using System.Net;
using Abstraction.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;

namespace Raritet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : Controller
{
    private IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    /// <summary>
    /// Returns books list
    /// </summary>
    /// <response code="200">Returns the books list</response>
    /// <response code="204">When the books can’t be received</response>
    [HttpGet("books")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    public async Task<List<BookDTO>> GetBooks()
    {
        return await Task.FromResult(_bookService.GetBooks());
    }

    /// <summary>
    /// Return new book's identifier code
    /// </summary>
    /// <param name="bookDto"></param>
    [HttpPost("add-book")]
    public async Task<int> AddAuthor(BookDTO bookDto)
    {
        return await _bookService.AddBook(bookDto);
    }
}