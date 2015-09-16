using System;
using System.Collections.Generic;
using System.Linq;

using DataHandle.Models;

namespace DataHandle.Entities
{
    public interface IUserGroupEntity : IRepository<UserGroup>
    {
        IQueryable<UserGroup> GetAll();
        UserGroup GetBy(int id);
        UserGroup GetBy(string name);
    }
}