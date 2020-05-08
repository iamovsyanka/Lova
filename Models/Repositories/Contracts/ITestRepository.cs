using Models.Models;

namespace Models.Repositories
{
    public interface ITestRepository : IRepository<Test>
    {
        public string GetTestNameById(int testId);
    }
}
