using Microsoft.EntityFrameworkCore;
using Models.Models;
using Models.Contexts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class TestRepository : ITestRepository
    {
        private LovaContext context;
        public TestRepository(LovaContext context)
        {
            this.context = context;
        }

        public IQueryable<Test> Get() => context.Tests;

        public async Task AddAsync(Test test)
        {
            if (test == null)
            {
                throw new ArgumentException();
            }

            await context.Tests.AddAsync(test);
            await context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int testId)
        {
            var testToRemove = await Get().FirstOrDefaultAsync(t => t.TestId == testId);

            if (testToRemove != null)
            {
                context.Tests.Remove(testToRemove);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(int testId, Test newTest)
        {
            var testToChange = await Get().FirstOrDefaultAsync(t => t.TestId == testId);
            
            if (testToChange != null)
            {
                testToChange.Name = newTest.Name;
                testToChange.Questions = newTest.Questions;

                await context.SaveChangesAsync();
            }
        }

        public string GetTestNameById(int testId)
        {
            var test = Get().FirstOrDefault(t => t.TestId == testId);
            return test != null ? test.Name : "";
        }

    }
}
