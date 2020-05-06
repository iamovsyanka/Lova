using Models.Models;
using System.Linq;

namespace Models.Repositories
{
    public interface IQuestionRepository : IRepository<Question>
    {
        public IQueryable<Question> GetQuestionsByTestId(int testId);
    }
}
