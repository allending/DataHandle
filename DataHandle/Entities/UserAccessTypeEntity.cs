using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using DataHandle.Models;

namespace DataHandle.Entities
{
    public class UserAccessTypeEntity : EfRepository<UserAccessType>, IUserAccessTypeEntity
    {

        public UserAccessTypeEntity(DbContext context, bool shareContext) : base(context, shareContext) { }

        public IQueryable<UserAccessType> GetAll()
        {
            return All();
        }

        public UserAccessType GetBy(int id)
        {
            return Find(u => u.Id == id);
        }

        public UserAccessType GetBy(string name)
        {
            return Find(u => u.Name == name);
        }


    }
}