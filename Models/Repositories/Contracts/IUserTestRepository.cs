using Models.Models;
using System.Linq;

namespace Models.Repositories
{
    public interface IUserTestRepository : IRepository<UserTest>
    {
        public IQueryable<UserTest> GetUserTestByUserId(int userId);
    }
}
