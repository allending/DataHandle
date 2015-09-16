using System;
using System.Collections.Generic;
using System.Linq;

using DataHandle.Entities;

namespace DataHandle
{
    public interface IAppContext
    {
        IUserAccessTypeEntity UserAccessTypes { get; }
        IUserModuleEntity UserModules { get; }
        IUserModuleAccessTypeEntity UserModuleAccessTypes { get; }
        IUserGroupEntity UserGroups { get; }
        IUserGroupModuleAccessEntity UserGroupModuleAccesses { get; }
        IUserEntity Users { get; }
        
        int SaveChanges();

        void Dispose();
    }
}