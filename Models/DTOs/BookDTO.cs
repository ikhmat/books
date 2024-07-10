namespace Models.DTOs;

public class BookDTO
{
    /// <summary>
    /// Identifier code
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Author identifier code
    /// </summary>
    public int AuthorId { get; set; }

    /// <summary>
    /// Link to Author
    /// </summary>
    public string AuthorName { get; set; }
}