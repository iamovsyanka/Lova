using Microsoft.EntityFrameworkCore;
using Models.Models;
using Models.Contexts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class UserTestRepository : IUserTestRepository
    {
        private LovaContext context;
        public UserTestRepository(LovaContext context)
        {
            this.context = context;
        }

        public IQueryable<UserTest> Get() => context.UserTests;

        public async Task AddAsync(UserTest userTest)
        {
            if (userTest == null)
            {
                throw new ArgumentException();
            }

            await context.UserTests.AddAsync(userTest);
            await context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int userTestId)
        {
            var userTestToRemove = await Get().FirstOrDefaultAsync(u => u.UserTestId == userTestId);

            if (userTestToRemove != null)
            {
                context.UserTests.Remove(userTestToRemove);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(int userTestId, UserTest newUserTest)
        {
            var userTestToChange = await Get().FirstOrDefaultAsync(u => u.UserTestId == userTestId);

            if(userTestToChange != null)
            {
                userTestToChange.Result = newUserTest.Result;
                userTestToChange.SolvedTime = newUserTest.SolvedTime;

                await context.SaveChangesAsync();
            }
        }
    }
}
