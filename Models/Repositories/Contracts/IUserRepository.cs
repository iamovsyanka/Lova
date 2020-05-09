using Models.Models;

namespace Models.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        public string GetUserNameById(int userId);
        public bool CheckAdmin(int userId);
    }
}