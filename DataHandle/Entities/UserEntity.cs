using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using DataHandle.Models;

namespace DataHandle.Entities
{
    public class UserEntity : EfRepository<User>, IUserEntity
    {

        public UserEntity(DbContext context, bool shareContext) : base(context, shareContext) { }

        public IQueryable<User> GetAll()
        {
            return All();
        }

        public User GetBy(int id)
        {
            return Find(u => u.Id == id);
        }

        public User GetBy(string username)
        {
            return Find(u => u.Username == username);
        }
    }
}