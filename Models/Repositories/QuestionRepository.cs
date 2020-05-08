using Microsoft.EntityFrameworkCore;
using Models.Models;
using Models.Contexts;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Models.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private LovaContext context;
        public QuestionRepository(LovaContext context)
        {
            this.context = context;
        }

        public IQueryable<Question> Get() => context.Questions;

        public async Task AddAsync(Question question)
        {
            if (question == null)
            {
                throw new ArgumentException();
            }

            await context.Questions.AddAsync(question);
            await context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int questionId)
        {
            var questionToRemove = await Get().FirstOrDefaultAsync(q => q.QuestionId == questionId);

            if (questionToRemove != null)
            {
                context.Questions.Remove(questionToRemove);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(int questionId, Question newQuestion)
        {
            var questionToChange = await Get().FirstOrDefaultAsync(q => q.QuestionId == questionId);

            if (questionToChange != null)
            {
                questionToChange.Test = newQuestion.Test;
                questionToChange.TestId = newQuestion.TestId;
                questionToChange.Answer= newQuestion.Answer;
                
                await context.SaveChangesAsync();
            }
        }

        public IQueryable<Question> GetQuestionsByTestId(int testId) => Get().Where(q => q.TestId == testId);
    }
}
