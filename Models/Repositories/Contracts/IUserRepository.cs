using Models.Models;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        public string GetUserNameById(int userId);
        public Task<bool> IsAdmin(int userId);
    }
}