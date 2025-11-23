namespace Explorer.Tours.API.Dtos;

public class QuizQuestionDto
{
    public long Id { get; set; }
    public long QuizId { get; set; }
    public string Text { get; set; }
    public bool AllowsMultipleAnswers { get; set; }
    public List<QuizAnswerOptionDto> Options { get; set; }
}