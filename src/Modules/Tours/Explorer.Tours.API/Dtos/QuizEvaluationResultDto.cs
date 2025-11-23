namespace Explorer.Tours.API.Dtos;

public class QuizEvaluationResultDto
{
    public long QuizId { get; set; }
    public List<QuestionEvaluationResultDto> Questions { get; set; }
}

public class QuestionEvaluationResultDto
{
    public long QuestionId { get; set; }
    public bool IsCompletelyCorrect { get; set; }
    public List<OptionEvaluationDto> Options { get; set; }
}

public class OptionEvaluationDto
{
    public long OptionId { get; set; }
    public string Text { get; set; }
    public bool IsCorrect { get; set; }
    public bool IsSelected { get; set; }
    public string Feedback { get; set; }
}