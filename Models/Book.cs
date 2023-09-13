namespace BookStore.Models;

public class Book
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }
    public Author Author { get; set; } = null!;
}