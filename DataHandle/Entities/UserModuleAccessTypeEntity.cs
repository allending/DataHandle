using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using DataHandle.Models;

namespace DataHandle.Entities
{
    public class UserModuleAccessTypeEntity : EfRepository<UserModuleAccessType>, IUserModuleAccessTypeEntity
    {

        public UserModuleAccessTypeEntity(DbContext context, bool shareContext) : base(context, shareContext) { }

        public IQueryable<UserModuleAccessType> GetAll()
        {
            return All();
        }

        public UserModuleAccessType GetBy(int id)
        {
            return Find(u => u.Id == id);
        }

    }
}