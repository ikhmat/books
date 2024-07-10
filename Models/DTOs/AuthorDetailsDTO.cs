namespace Models.DTOs;

public class AuthorDetailsDTO : AuthorDTO
{
    public ICollection<BookDTO> Books { get; set; }
}