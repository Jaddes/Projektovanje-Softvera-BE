namespace Explorer.Tours.API.Dtos;

public class QuizDto
{
    public long Id { get; set; }
    public long AuthorId { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public List<QuizQuestionDto> Questions { get; set; }
}