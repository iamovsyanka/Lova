﻿using Microsoft.EntityFrameworkCore;
using Models.Models;
using Models.Contexts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        private LovaContext context;
        public UserRepository(LovaContext context)
        {
            this.context = context;
        }

        public IQueryable<User> Get() => context.Users;

        public async Task AddAsync(User user)
        {
            if (user == null)
            {
                throw new ArgumentException();
            }

            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int userId)
        {
            var userToRemove = await Get().FirstOrDefaultAsync(u => u.Id == userId);

            if(userToRemove != null)
            {
                context.Users.Remove(userToRemove);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(int userId, User newUser)
        {
            var userToChange = await Get().FirstOrDefaultAsync(u => u.Id == userId);

            if (userToChange != null) 
            {
                userToChange.Password = newUser.Password;
                userToChange.UserName = newUser.UserName;

                await context.SaveChangesAsync();
            }
        }

        public async Task<bool> IsAdmin(int userId)
        {
            var user = await Get().FirstOrDefaultAsync(u => u.Id == userId);
            return user.Role == Enums.Role.Admin;
        }

        public string GetUserNameById(int userId)
        {
            var user = Get().FirstOrDefault(u => u.Id == userId);
            return user != null ? user.UserName : "";
        }
    }
}
