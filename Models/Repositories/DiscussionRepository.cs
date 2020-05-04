using Microsoft.EntityFrameworkCore;
using Models.Contexts;
using Models.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class DiscussionRepository : IDiscussionRepository
    {
        private LovaContext context;
        public DiscussionRepository(LovaContext context)
        {
            this.context = context;
        }

        public IQueryable<Discussion> Get() => context.Discussions;

        public async Task AddAsync(Discussion discussion)
        {
            if (discussion == null)
            {
                throw new ArgumentException();
            }

            await context.Discussions.AddAsync(discussion);
            await context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int discussionId)
        {
            var discussionToRemove = await Get().FirstOrDefaultAsync(d => d.DiscussionId == discussionId);

            if(discussionToRemove != null)
            {
                context.Discussions.Remove(discussionToRemove);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(int discussionId, Discussion newDiscussion)
        {
            var discussionToChange = await Get().FirstOrDefaultAsync(d => d.DiscussionId == discussionId);

            if (discussionToChange != null)
            {
                discussionToChange.Forum = newDiscussion.Forum;
                discussionToChange.ForumId = newDiscussion.ForumId;
                discussionToChange.Messages = newDiscussion.Messages;

                await context.SaveChangesAsync();
            }
        }
    }
}
