using System;
using System.Collections.Generic;
using System.Linq;

using DataHandle.Models;

namespace DataHandle.Entities
{
    public interface IUserModuleAccessTypeEntity : IRepository<UserModuleAccessType>
    {
        IQueryable<UserModuleAccessType> GetAll();
        UserModuleAccessType GetBy(int id);
    }
}