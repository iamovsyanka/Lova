using Microsoft.EntityFrameworkCore;
using Models.Models;
using Models.Contexts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private LovaContext context;
        public MessageRepository(LovaContext context)
        {
            this.context = context;
        }

        public IQueryable<Message> Get() => context.Messages;

        public async Task AddAsync(Message message)
        {
            if (message == null)
            {
                throw new ArgumentException();
            }

            await context.Messages.AddAsync(message);
            await context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int messageId)
        {
            var messageToRemove = await Get().FirstOrDefaultAsync(m => m.MessageId == messageId);

            if(messageToRemove != null)
            {
                context.Messages.Remove(messageToRemove);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(int messageId, Message newMessage)
        {
            var messageToChange = await Get().FirstOrDefaultAsync(m => m.MessageId == messageId);

            if (messageToChange != null)
            {
                messageToChange.Text = newMessage.Text;
                messageToChange.When = newMessage.When;

                await context.SaveChangesAsync();
            }
        }
    }
}
