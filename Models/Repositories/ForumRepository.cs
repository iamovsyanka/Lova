using Microsoft.EntityFrameworkCore;
using Models.Contexts;
using Models.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class ForumRepository : IForumRepository
    {
        private LovaContext context;
        public ForumRepository(LovaContext context)
        {
            this.context = context;
        }

        public IQueryable<Forum> Get() => context.Forums;

        public async Task AddAsync(Forum forum)
        {
            if (forum == null)
            {
                throw new ArgumentException();
            }
 
            await context.Forums.AddAsync(forum);
            await context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int forumId)
        {
            var forumToRemove = await Get().FirstOrDefaultAsync(f => f.ForumId == forumId);

            if (forumToRemove != null)
            {
                context.Forums.Remove(forumToRemove);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(int forumId, Forum newForum)
        {
            var forumToChange = await Get().FirstOrDefaultAsync(f => f.ForumId == forumId);

            if (forumToChange != null)
            {
                forumToChange.Discussions = newForum.Discussions;
                await context.SaveChangesAsync();
            }
        }
    }
}
