using Models.Models;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public interface IDiscussionRepository : IRepository<Discussion>
    {
        public Task RemoveByNameAsync(string discussionName);
    }
}
