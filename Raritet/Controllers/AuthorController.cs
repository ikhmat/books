using System.Net;
using Abstraction.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;

namespace Raritet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorController : Controller
{
    private IAuthorService _authorService;

    public AuthorController(IAuthorService authorService)
    {
        _authorService = authorService;
    }
    
    /// <summary>
    /// Returns authors list
    /// </summary>
    /// <response code="200">Returns the authors list</response>
    /// <response code="204">When the authors can’t be received</response>
    [HttpGet("authors")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    public async Task<IQueryable<AuthorDTO>> GetAuthors()
    {
        return await Task.FromResult(_authorService.GetAuthors());
    }

    /// <summary>
    /// Return author with books
    /// </summary>
    /// <param name="id"></param>
    [HttpGet("author/{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    public async Task<AuthorDetailsDTO> GetAuthor([FromRoute] int id)
    {
        return await _authorService.GetAuthor(id);
    }

    /// <summary>
    /// Return new author's identifier code
    /// </summary>
    /// <param name="authorDto"></param>
    [HttpPost("add-author")]
    public async Task<int> AddAuthor(AuthorDTO authorDto)
    {
        return await _authorService.AddAuthor(authorDto);
    }
}