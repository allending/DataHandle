using System;
using System.Collections.Generic;
using System.Linq;

using DataHandle.Models;

namespace DataHandle.Entities
{
    public interface IUserAccessTypeEntity : IRepository<UserAccessType>
    {
        IQueryable<UserAccessType> GetAll();
        UserAccessType GetBy(int id);
        UserAccessType GetBy(string name);
    }
}