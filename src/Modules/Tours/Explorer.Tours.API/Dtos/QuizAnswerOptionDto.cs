namespace Explorer.Tours.API.Dtos;

public class QuizAnswerOptionDto
{
    public long Id { get; set; }
    public long QuestionId { get; set; }
    public string Text { get; set; }
    public string Feedback { get; set; }
    public bool IsCorrect { get; set; }
}