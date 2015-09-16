using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using DataHandle.Entities;

namespace DataHandle
{


    public class AppContext : IAppContext
    {
        private readonly DbContext _db;

        public IUserModuleEntity UserModules { get; private set; }
        public IUserAccessTypeEntity UserAccessTypes { get; private set; }
        public IUserModuleAccessTypeEntity UserModuleAccessTypes { get; private set; }
        public IUserGroupEntity UserGroups { get; private set; }
        public IUserGroupModuleAccessEntity UserGroupModuleAccesses { get; private set; }
        public IUserEntity Users { get; private set; }

        public AppContext(
            string connectionString,
            DbContext context = null,
            IUserModuleEntity userModules = null,
            IUserAccessTypeEntity userAccessTypes = null,
            IUserModuleAccessTypeEntity userModuleAccessTypes = null,
            IUserGroupEntity  userGroups = null,
            IUserGroupModuleAccessEntity userGroupModuleAccesses = null,
            IUserEntity users = null

        )

        {
            _db = context ?? new AppDatabase(connectionString);    
            UserAccessTypes = userAccessTypes ?? new UserAccessTypeEntity(_db, true);
            UserModules = userModules ?? new UserModuleEntity(_db, true);
            UserModuleAccessTypes = userModuleAccessTypes ?? new UserModuleAccessTypeEntity(_db, true);
            UserGroups = userGroups ?? new UserGroupEntity(_db, true);
            UserGroupModuleAccesses = userGroupModuleAccesses ?? new UserGroupModuleAccessEntity(_db, true);
            Users = users ?? new UserEntity(_db, true);

        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db != null) { _db.Dispose(); }
        }
    }
}