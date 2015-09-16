using System;
using System.Collections.Generic;
using System.Linq;

using DataHandle.Models;

namespace DataHandle.Entities{
    public interface IUserGroupModuleAccessEntity : IRepository<UserGroupModuleAccess>
    {
        IQueryable<UserGroupModuleAccess> GetAll();
        UserGroupModuleAccess GetBy(int id);
        UserGroupModuleAccess GetBy(int groupId, int moduleAccessTypeId);
        UserGroupModuleAccess GetAccess(int groupId, int moduleId, int accessTypeId);
        IQueryable<UserGroupModuleAccess> GetByGroup(int groupId);
        IQueryable<UserGroupModuleAccess> GetAccesses(int groupId, int moduleId);
        //IQueryable<UserGroupModuleAccess> GetAllModulesBy(int groupId);
        //UserGroupModuleAccess GetBy(int groupId);
    }
}