using Models.Models;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public interface ITestRepository : IRepository<Test>
    {
        public string GetTestNameById(int testId);
        public Task RemoveByNameAsync(string testName);
    }
}
