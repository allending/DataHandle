using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using DataHandle.Models;

namespace DataHandle.Entities
{
    public class UserGroupEntity : EfRepository<UserGroup>, IUserGroupEntity
    {

        public UserGroupEntity(DbContext context, bool shareContext) : base(context, shareContext) { }

        public IQueryable<UserGroup> GetAll()
        {
            return All();
        }

        public UserGroup GetBy(int id)
        {
            return Find(u => u.Id == id);
        }

        public UserGroup GetBy(string groupname)
        {
            return Find(u => u.Name == groupname);
        }
    }
}