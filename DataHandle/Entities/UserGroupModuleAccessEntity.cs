using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using DataHandle.Models;

namespace DataHandle.Entities
{
    public class UserGroupModuleAccessEntity : EfRepository<UserGroupModuleAccess>, IUserGroupModuleAccessEntity
    {

        public UserGroupModuleAccessEntity(DbContext context, bool shareContext) : base(context, shareContext) { }

        public IQueryable<UserGroupModuleAccess> GetAll()
        {
            return All();
        }

        public UserGroupModuleAccess GetAccess(int groupId, int moduleId, int accessTypeId)
        {
            return Find(gma => gma.UserGroupId == groupId && gma.ModuleAccessType.UserModuleId == moduleId && gma.ModuleAccessType.UserAccessTypeId == accessTypeId);
        }

        public IQueryable<UserGroupModuleAccess> GetAccesses(int groupId, int moduleId)
        {
            return FindAll(gma => gma.UserGroupId == groupId && gma.ModuleAccessType.UserModuleId == moduleId);
        }

        public UserGroupModuleAccess GetBy(int groupId, int moduleAccessTypeId)
        {
            return Find(u => u.UserGroupId == groupId && u.UserModuleAccessTypeId == moduleAccessTypeId);
        }

        public UserGroupModuleAccess GetBy(int id)
        {
            return Find(gma => gma.Id == id);
        }

        public IQueryable<UserGroupModuleAccess> GetByGroup(int groupId)
        {
            return FindAll(u => u.UserGroupId == groupId);
        }

    }
}