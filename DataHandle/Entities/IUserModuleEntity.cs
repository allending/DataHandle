using System;
using System.Collections.Generic;
using System.Linq;

using DataHandle.Models;

namespace DataHandle.Entities{
    public interface IUserModuleEntity : IRepository<UserModule>
    {
        IQueryable<UserModule> GetAll();
        UserModule GetBy(int id);
        UserModule GetBy(string controller);
        IQueryable<UserModule> GetManyBy(int? parentModuleId = null);
        IQueryable<UserModule> GetManyByGroup(int groupId, int? moduleId = null);
    }
}