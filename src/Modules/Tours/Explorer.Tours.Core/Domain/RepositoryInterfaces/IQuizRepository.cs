using Explorer.Tours.Core.Domain.Quiz;

namespace Explorer.Tours.Core.Domain.RepositoryInterfaces;

public interface IQuizRepository
{
    List<Quiz> GetOwned(long authorId);
    Quiz? GetById(long quizId);
    Quiz GetWithDetails(long quizId);
    Quiz Create(Quiz quiz);
    Quiz Update(Quiz quiz);
    void Delete(long quizId);
    List<Quiz> GetAllForTourists();
}